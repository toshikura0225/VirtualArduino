/*
＜修正事項＞Q
・INPUT_PULLUPに対応（現在はpiModeはbool型のためINPUT_PULLUP(=2)を使用できない）
・7WSEGを読む機能
*/

#include <SoftwareSerial.h>
#include <EEPROM.h>
#include <Wire.h>
#include <SPI.h>

const int SOFTWARE_NUMBER = 7;
const int SOFTWARE_VERSION = 1;

/* How many shift register chips ar+e daisy-chained.
*/
//#define NUMBER_OF_SHIFT_CHIPS   1
/* Width of data (how many ext lines).
*/
//#define DATA_WIDTH   NUMBER_OF_SHIFT_CHIPS * 8
/* Width of pulse to trigger the shift register to read and latch.
*/
#define PULSE_WIDTH_USEC   5
/* Optional delay between shift register reads.
*/
//#define POLL_DELAY_MSEC   1
/* You will need to change the "int" to "long" If the
* NUMBER_OF_SHIFT_CHIPS is higher than 2.
*/



// 上位アドレスが示すデータ種類
const byte HREGIST_PIN_CONFIG = 0;              // ピン設定
const byte HREGIST_PIN_DATA = 1;                // ピン入出力値
const byte HREGIST_SHIFT_OUTPUT_DATA = 2;       // シフト出力値
const byte HREGIST_SHIFT_INPUT_DATA = 3;        // シフト入力値
const byte HREGIST_SOFTWARE_SERIAL = 4;         // ソフトウェアシリアル設定
const byte HREGIST_SPI = 5;                     // SPI
const byte HREGIST_I2C = 6;                     // I2C
const byte HREGIST_EEP_INIT_DATA = 10;          // 制御変数メモリ
const byte HREGIST_EEP_GENERAL_DATA = 11;       // 汎用メモリ
const byte HREGIST_COM = 12;                    // 汎用実行（書込みで関数＊＊を実行する）
const byte HREGIST_SOFTWARE_NO_VER = 98;        // ソフトウエア
const byte HREGIST_INIT = 99;                   // 書き込むと初期化する領域
												/*
												int pinDirection[20] = { OUTPUT, OUTPUT, OUTPUT, OUTPUT, OUTPUT,
												OUTPUT, OUTPUT, OUTPUT, OUTPUT, OUTPUT,
												OUTPUT, OUTPUT, OUTPUT, OUTPUT, OUTPUT,
												OUTPUT, OUTPUT, OUTPUT, OUTPUT, OUTPUT };  // pinMode設定値
												*/
int pinDirection[20] = { INPUT, INPUT, INPUT, INPUT, INPUT,
INPUT, INPUT, INPUT, INPUT, INPUT,
INPUT, INPUT, INPUT, INPUT, INPUT,
INPUT, INPUT, INPUT, INPUT, INPUT };  // pinMode設定値


									  // ■■■　入出力方向値　■■■
const byte DIGITAL_MODE = 0;            // デジタルピン
const byte ANALOG_MODE = 1;             // アナログピン
const byte OTHER_MODE = 2;              // その他制御モード

byte pinType[20] = { 255, 255, DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE,
DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE,
DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE, DIGITAL_MODE, ANALOG_MODE,
ANALOG_MODE, ANALOG_MODE, ANALOG_MODE, ANALOG_MODE, ANALOG_MODE };    // 入出力モード

																	  // ■■■　入出力データ値　■■■
int intData[20] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };         // 入出力データ

																						  // ■■■　シフトレジスタ　■■■
const byte LREGIST_SHIFT_PIN_1 = 0;    // 拡張ボード数，Latchピン
const byte LREGIST_SHIFT_PIN_2 = 1;    // clock, dataピン
const byte LREGIST_DATA_FROM = 2;      // データの先頭レジストリアドレス
byte numberOfShiftOutputBoard = 0;     // シフト出力拡張ボード数
byte pinOutputLatch = 2, pinOutputClock = 3, pinOutputData = 4;      // シフト出力制御ピン
byte shiftOutputData[3] = { 0, 0, 0 };     // シフト出力データ

byte numberOfShiftInputBoard = 2;     // シフト入力拡張ボード数（▲▲▲保留　ボート１のみ）
byte pinInputLatch = 5, pinInputClock = 6, pinInputData = 7;      // シフト入力制御ピン
byte shiftInputData[3] = { 0, 0, 0 };      // シフト入力データ

										   // ■■■　ソフトウェアシリアル　■■■
SoftwareSerial softwareSerial(2, 3);      // ソフトウェアシリアル
byte pinSoftwareSerial_RX;      // 受信ピン
byte pinSoftwareSerial_TX;      // 送信ピン

								// ■■■　SPI　■■■
const byte LREGIST_SPI_BEGIN = 0;     // 書込みでSPI.begin()を実行する
const byte LREGIST_SPI_SETTING = 1;   // 書込みでSPI.setDataMode()とSPI.setClockDivider()を実行する
const byte LREGIST_SPI_TRANSFER = 2;  // 書込みでSPI.transfer()を実行する
const byte LREGIST_SPI_END = 3;  // 書込みでSPI.transfer()を実行する

									  // ■■■　I2C　■■■
const byte LREGIST_I2C_BEGIN = 0;     // 書込みでI2C.begin()を実行する
const byte LREGIST_I2C_BEGINTRANS = 1;// 書込みでI2C.beginTransmission()を実行する
const byte LREGIST_I2C_WRITE = 2;     // 書込みでI2C.write()を実行する
const byte LREGIST_I2C_ENDTRANS = 3;  // 書込みでI2C.endTransmission()を実行する


									  // ■■■　プログラム設定（不揮発）　■■■
const byte LREGIST_EEP_DEVICE_ADDRESS = 0;             // デバイスアドレス
const byte LREGIST_EEP_BAUD_RATE_CODE = 1;             // (通常)シリアルのボーレート
const byte LREGIST_EEP_SOFTWARE_SERIAL_BAUD_RATE = 2;  // ソフトウェアシリアルのボーレート
const byte LREGIST_EEP_TIMEOUT_COUNT = 3;              // タイムアウトカウント値（×１０００）
byte eepDeviceAddress = 0;                     // デバイスアドレス
byte eepBaudRateCode = 4;                      // (通常)シリアルのボーレート
byte eepSoftwareSerialBaudRateCode = 4;       // ソフトウェアシリアルのボーレート
byte eepTimeoutCount = 15;                      // タイムアウトカウント値（×１０００）

												// ■■■　不揮発メモリ　■■■
byte eepGeneralStrageArea[10] = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };  // 汎用EEPROMデータ

																   // ■■■　汎用　■■■
const byte LREGIST_COM_DELAY = 0;   // 書込みでdelay()を実行する


const int MAX_READ_SIZE = 32;      // 受信データ最大サイズ
byte readData[MAX_READ_SIZE];        // 受信データ
int readLength = 0;                  // 受信データサイズ


									 // the setup routine runs once when you press reset:
void setup() {
	// HREGIST_INITialize the digital pin as an output.

	delay(1000);      // 電源ON/OFFの繰り返した場合の連続的なEEPROM読込みを回避するため

					  // ▲▲▲保留（設定は記憶されず初期値で動作するものとする）▲▲▲
					  //getEEPROM();      // EEPROMからすべての設定値を読込み（制御設定値＆汎用記憶メモリ）

					  // ポートの入出力方向を設定（デジタルピンのみ、アナログピンはアナログとして使用する場合は設定不要）
	for (int i = 2; i <= 13; i++) { pinMode(i, pinDirection[i]);  digitalWrite(i, LOW); };

	// 制御用シリアル通信開始
	// ▲▲▲時にボーレートは9600固定とする
	//eepBaudRateCode = EEPROM.read(two2one(HREGIST_EEP_INIT_DATA, LREGIST_EEP_BAUD_RATE_CODE));
	// Serial.begin(code2baudrate(eepBaudRateCode));
  //Serial.begin(9600);
  Serial.begin(57600);

}

// the loop routine runs over and over again forever:

int timeoutCount = 0;                // タイムアウトカウンタ
void loop() {



	if (Serial.available() > 0) {
		// 受信データあり
		if (dataReceive() == true) {
			// 全データ受信完了

			request2board();    // 通信データによる指令を反映する

			readLength = 0;
		}
		timeoutCount = 0;
	}


	// タイムアウトチェック
	if (timeoutCount == eepTimeoutCount * 1000 && readLength != 0) {
		// タイムアウト発生

		sendTimeoutCommand();  // タイムアウトコマンドを送信
		readLength = 0;

		Serial.write(0x15);

	}

	// タイムアウトカウンタのインクリメント
	if (timeoutCount < 30000) {

		timeoutCount++;
	}

}

// 8バイト受信で受信完了とする
// データを受信し、全データ受信完了か否かを戻り値で返す（ファンクションコードは0x03または0x06のみの対応）
boolean dataReceive() {
	boolean flag = false;

	readData[readLength++] = Serial.read(); // 受信データを読み込む
	if (readLength >= 8) flag = true;        // 0x03も0x06もリクエストは8bytes

	return flag;
}

/// <summary>
/// CRCチェック（転記）
/// </summary>
/// <param name="buf">チェックするデータ（byte配列）</param>
/// <param name="len">CRCを除く送信データ長</param>
/// <returns>CRC計算結果（byte配列）</returns>
bool checkCRC(byte buf[], int len) {
	bool retFlag;
	int CRC;
	int carry;
	int n;
	int k = 0;
	CRC = 0xFFFF;
	while (k < len) {
		CRC ^= buf[k];
		for (n = 0; n < 8; n++) {
			carry = CRC & 1;
			CRC >>= 1;
			if (carry == 1) {
				CRC ^= 0xA001;
			}
		}
		k++;
	}
	byte byteCRC[2];
	byteCRC[1] = (byte)(CRC / 256);
	byteCRC[0] = (byte)(CRC % 256);
	if (buf[len] == byteCRC[0] && buf[len + 1] == byteCRC[1]) {
		retFlag = true;
	}
	else {
		retFlag = false;
	}
	return retFlag;
}

int GetCRC(byte bytes[], int checkLength)
{
	int CRC;
	int carry;
	int n;
	int k = 0;
	CRC = 0xFFFF;
	while (k < checkLength)
	{
		CRC ^= bytes[k];
		for (n = 0; n < 8; n++)
		{
			carry = CRC & 1;
			CRC >>= 1;
			if (carry == 1)
			{
				CRC ^= 0xA001;
			}
		}
		k++;
	}

	return CRC;
}


// 通信データによる指令を反映する
void request2board() {

	int startAddress = two2one(readData[2], readData[3]);	// デバイスアドレス
	int noOfPoints = two2one(readData[4], readData[5]);	// データ数

	int num, count = 0;  // temporary value

						 // 自分宛てのデータであれば受信データを処理する      
	if (eepDeviceAddress == readData[0]) {

		// 返答
		switch (readData[1]) {

			// ファンクションコード0x03
			case 0x03:
                        {

				// デバイスアドレス
				Serial.write(readData[0]);

				// ファンクションコード0x03
				Serial.write(readData[1]);

				// データ数
				int byte_count = two2one(readData[4], readData[5]) * 2;

				Serial.write(byte_count);

				// 返信データ
				count = 0;
				while (count < two2one(readData[4], readData[5])) {

					int value = getRegisteredValue(two2one(readData[2], readData[3]) + count);

					Serial.write(highByte(value));
					Serial.write(lowByte(value));
					//Serial.write(lowByte(getRegisteredValue(two2one(readData[2], readData[3])+count)));
					//getRegisteredValue(readData[2], readData[3]);
					count++;
				}
 
				// CRCコード送信
				int CRC = GetCRC(readData, byte_count + 3);
				Serial.write(CRC & 255);
				Serial.write((CRC >> 8) & 255);

				break;
                        }

				// ファンクションコード0x06
			case 0x06:
				for (int num = 0; num < 8; num++) {
					Serial.write(readData[num]);
				}

				setRegisteredValue(readData[2], readData[3], readData[4], readData[5]);

				break;

			default:
				// 未対応
				break;
		}
	}
	else {
		// CRCエラーやアドレスが異なる場合

		// 無応答
	}

}

// 2バイトのbyte配列をint型変数に変換
int two2one(byte b1, byte b2) { return (b1 * 256 + b2); };


// レジスタの値を取得（存在しない場合は０を返答）
int getRegisteredValue(int address) {

	int retValue = 0;
	byte addressH = highByte(address);
	byte addressL = lowByte(address);

	switch (addressH) {

		case HREGIST_PIN_CONFIG:
			// pinMode設定値
			if (addressL <= 19)  retValue = two2one(pinDirection[addressL], pinType[addressL]);
			break;

		case HREGIST_PIN_DATA:
			// pin出力値
			if (addressL <= 19) {
				switch (pinType[addressL]) {
					case DIGITAL_MODE:
						if (pinDirection[addressL] == INPUT) intData[addressL] = digitalRead(addressL);          // デジタル入力
						break;
					case ANALOG_MODE:
						if (pinDirection[addressL] == INPUT) intData[addressL] = analogRead(addressL - 14);      // アナログ入力
						break;
					case OTHER_MODE:
						// DO NOTHING
						break;

					default:
						break;
				}
			}

			retValue = intData[addressL];

			break;

		case HREGIST_SHIFT_OUTPUT_DATA:
			switch (addressL) {

				case LREGIST_SHIFT_PIN_1:
					// 拡張ボード数，Latchピン
					retValue = two2one(numberOfShiftOutputBoard, pinOutputLatch);
					break;

				case LREGIST_SHIFT_PIN_2:
					// clock, dataピン
					retValue = two2one(pinOutputClock, pinOutputData);
					break;

				default:
					// DO NOTHING...
					retValue = shiftOutputData[addressL - LREGIST_DATA_FROM];
					break;
			}
			// シフト出力
			// if (addressL <= 2)  retValue = shiftOutputData[addressL];
			break;

		case HREGIST_SHIFT_INPUT_DATA:
			// シフト入力
			switch (addressL) {

				case LREGIST_SHIFT_PIN_1:
					// 拡張ボード数，Latchピン
					retValue = two2one(numberOfShiftInputBoard, pinInputLatch);
					break;

				case LREGIST_SHIFT_PIN_2:
					// clock, dataピン
					retValue = two2one(pinInputClock, pinInputData);
					break;

				default:
					// Shift入力（▲▲▲保留　ボート１のみ）
					shiftInputData[addressL - LREGIST_DATA_FROM] = read_shift_regs(addressL - LREGIST_DATA_FROM);
					retValue = shiftInputData[addressL - LREGIST_DATA_FROM];

					break;

			}
			break;

		case HREGIST_SOFTWARE_SERIAL:
			// ソフトウェアシリアル
			retValue = two2one(pinSoftwareSerial_RX, pinSoftwareSerial_TX);
			break;

		case HREGIST_EEP_INIT_DATA:
			switch (addressL) {
				case LREGIST_EEP_DEVICE_ADDRESS:  retValue = eepDeviceAddress;  break;  // デバイスアドレス

				case LREGIST_EEP_BAUD_RATE_CODE:  retValue = eepBaudRateCode;  break;  // (通常)シリアルのボーレート

				case LREGIST_EEP_SOFTWARE_SERIAL_BAUD_RATE:  retValue = eepSoftwareSerialBaudRateCode;  break;  // ソフトウェアシリアルのボーレート

				case LREGIST_EEP_TIMEOUT_COUNT:  retValue = eepTimeoutCount;  break;  // タイムアウトカウント値（×１０００）
			}
			break;

		case HREGIST_EEP_GENERAL_DATA:
			eepGeneralStrageArea[addressL] = EEPROM.read(two2one(addressH, addressL));
			retValue = eepGeneralStrageArea[addressL];    // 汎用メモリ
			break;

		case HREGIST_INIT:
			retValue = 999;
			break;

		case HREGIST_SOFTWARE_NO_VER:
			retValue = two2one(SOFTWARE_NUMBER, SOFTWARE_VERSION);
			break;


		default:
			// 登録なし
			//retValue = trans;
			break;

	}

	return retValue;
}

// レジスタの値を設定
void setRegisteredValue(byte addressH, byte addressL, byte valueH, byte valueL) {

	switch (addressH) {

		case HREGIST_PIN_CONFIG:
			// pinMode設定値，ピンタイプ
			if (addressL <= 19 && valueH < 3) {
				// アナログピンのピン番号対策

				//if (pinDirection[addressL] != valueH) {
				// pinMode設定値が現設定と異なる
				pinDirection[addressL] = valueH;
				pinMode(addressL, valueH);
				//}

				//if (pinType[addressL] != valueL) {
				// ピンタイプが現設定と異なる
				pinType[addressL] = valueL;
				//}
			}
			break;

		case HREGIST_PIN_DATA:
			// ピンデータ
			if (valueH != 1) {
				//if (intData[addressL] != valueL) {

				intData[addressL] = valueL;

				switch (pinType[addressL]) {
					case DIGITAL_MODE:
						digitalWrite(addressL, valueL);    // デジタル出力
						break;
					case ANALOG_MODE:
						analogWrite(addressL, valueL);	// ＰＷＭ出力
						break;
					case OTHER_MODE:
						// DO NOTHING
					default:
						break;
				}
				//}
			}
			break;

		case HREGIST_SHIFT_OUTPUT_DATA:
			switch (addressL) {

				case LREGIST_SHIFT_PIN_1:
					// 拡張ボード数，Latchピン
					numberOfShiftOutputBoard = valueH;
					pinOutputLatch = valueL;
					pinMode(pinOutputLatch, OUTPUT);
					break;

				case LREGIST_SHIFT_PIN_2:
					// clock, dataピン
					pinOutputClock = valueH;
					pinOutputData = valueL;
					pinMode(pinOutputClock, OUTPUT);
					pinMode(pinOutputData, OUTPUT);

					break;

				default:
					// Shift入力（▲▲▲保留　ボート１のみ）
					write_shift_regs(valueL);
					shiftOutputData[0] = valueL;
					break;
			}

			break;

		case HREGIST_SHIFT_INPUT_DATA:
			switch (addressL) {

				case LREGIST_SHIFT_PIN_1:
					// 拡張ボード数，Latchピン
					numberOfShiftInputBoard = valueH;
					pinInputLatch = valueL;
					pinMode(pinInputLatch, OUTPUT);
					digitalWrite(pinOutputLatch, HIGH);
					break;

				case LREGIST_SHIFT_PIN_2:
					// clock, dataピン
					pinInputClock = valueH;
					pinInputData = valueL;
					pinMode(pinInputClock, OUTPUT);
					pinMode(pinInputData, INPUT);
					digitalWrite(pinOutputClock, LOW);
					break;

				default:
					// DO NOTHING...
					break;
			}

			break;

		case HREGIST_SPI:
			switch (addressL)
			{
				case LREGIST_SPI_BEGIN:
					SPI.begin();
					break;

				case LREGIST_SPI_SETTING:
					SPI.setDataMode(valueH);
					SPI.setClockDivider(valueL);
					break;

				case LREGIST_SPI_TRANSFER:
					SPI.transfer(valueL);
					break;

				case LREGIST_SPI_END:
					SPI.end();
					break;
			}

			break;

		case HREGIST_I2C:
			switch (addressL)
			{
				case LREGIST_I2C_BEGIN:
					Wire.begin(); // I2Cバスに接続
					break;

				case LREGIST_I2C_BEGINTRANS:
					Wire.beginTransmission(valueL);
					break;

				case LREGIST_I2C_WRITE:
					Wire.write(valueL);
					break;

				case LREGIST_I2C_ENDTRANS:
					Wire.endTransmission();
					break;
			}

			break;


		case HREGIST_SOFTWARE_SERIAL:
			// ソフトウェアシリアル
			pinSoftwareSerial_RX = valueH;
			pinSoftwareSerial_TX = valueL;
			break;

		case HREGIST_EEP_INIT_DATA:
			// 制御変数メモリ
			switch (addressL) {
				case LREGIST_EEP_DEVICE_ADDRESS:  eepDeviceAddress = valueL;  break;  // デバイスアドレス

				case LREGIST_EEP_BAUD_RATE_CODE:
					EEPROM.write(two2one(HREGIST_EEP_INIT_DATA, LREGIST_EEP_BAUD_RATE_CODE), valueL);
					eepBaudRateCode = valueL;
					Serial.end();
					delay(1000);
					Serial.begin(code2baudrate(eepBaudRateCode));
					break;  // (通常)シリアルのボーレート

				case LREGIST_EEP_SOFTWARE_SERIAL_BAUD_RATE: eepSoftwareSerialBaudRateCode = valueL; break;  // ソフトウェアシリアルのボーレート

				case LREGIST_EEP_TIMEOUT_COUNT:   eepTimeoutCount = valueL;  break;  // タイムアウトカウント値（×１０００）
			}
			break;

		case HREGIST_EEP_GENERAL_DATA:
			EEPROM.write(two2one(addressH, addressL), valueL);
			eepGeneralStrageArea[addressL] = valueL;    // 汎用メモリ
														// ▲▲▲ 保留（実際はEEPROMへ記憶）
			break;

		case HREGIST_COM:

			switch (addressL)
			{
				case LREGIST_COM_DELAY:
					delay(two2one(valueH, valueL));   // delay関数を実行
					break;
			}
			break;

		case HREGIST_INIT:
			// ▲▲▲ 保留（実際は初期値でEEPROMを書き換え＆変数も初期値に）
			break;

		default:
			// 登録なし

			break;

	}
}


// 不正コード応答
void sendIllegalCommand(byte argFunctionCode) {

}

// タイムアウトコマンドを送信
void sendTimeoutCommand() {

}


// EEPROMからすべての設定値を読込み（制御設定値＆汎用記憶メモリ）
void getEEPROM() {
	// ▲▲▲保留（設定は記憶されず初期値で動作するものとする）▲▲▲
}


// ボーレートのコードをボーレートに変換　０：９６００　１：１９２００　２：３８４００　３：５７６００　４：１１５２００	
long code2baudrate(byte code) {

	long ret;  // 戻り値とするボーレート値
	switch (code) {
		case 0:      ret = 9600;     break;
		case 1:      ret = 19200;    break;
		case 2:      ret = 38400;    break;
		case 3:      ret = 57600;    break;
		case 4:      ret = 115200;   break;
		default:     ret = 9600;     break;
	}

	return ret;
}




//byte numberOfShiftOutputBoard = 0;     // シフト出力拡張ボード数
//byte pinOutputLatch=2, pinOutputClock=3, pinOutputData=4;      // シフト出力制御ピン
//byte shiftOutputData[3] = { 0, 0, 0 };     // シフト出力データ


//int ploadPin        = 8;  // Connects to Parallel load pin the 165
//int clockEnablePin  = 9;  // Connects to Clock Enable pin the 165
//int dataPin         = 11; // Connects to the Q7 pin the 165
//int clockPin        = 12; // Connects to the Clock pin the 165

/* This function is essentially a "shift-in" routine reading the
* serial Data from the shift register chips and representing
* the state of those pins in an unsigned integer (or long).
*/
byte trans = 0;
byte read_shift_regs(byte board)
{
	byte bitVal;
	long bytesVal = 0;

	/* Trigger a parallel Load to latch the state of the data lines,
	*/
	//    digitalWrite(9, HIGH);
	digitalWrite(pinInputLatch, LOW);
	delayMicroseconds(PULSE_WIDTH_USEC);
	//delay(PULSE_WIDTH_MSEC);
	digitalWrite(pinInputLatch, HIGH);
	//    digitalWrite(9, LOW);

	/* Loop to read each bit value from the serial out line
	* of the SN74HC165N.
	*/
	/*
	for(int i = 0; i < board * 8; i++) {
	bitVal = digitalRead(pinInputData);
	trans |= (bitVal << ((8-1) - i));

	digitalWrite(pinInputClock, HIGH);
	delayMicroseconds(PULSE_WIDTH_USEC);
	digitalWrite(pinInputClock, LOW);
	}
	*/

	for (int i = 0; i < numberOfShiftInputBoard * 8; i++)
	{
		bitVal = digitalRead(pinInputData);

		bytesVal |= (bitVal << ((numberOfShiftInputBoard * 8 - 1) - i));


		digitalWrite(pinInputClock, HIGH);
		delayMicroseconds(PULSE_WIDTH_USEC);
		digitalWrite(pinInputClock, LOW);
	}

	//   bytesVal = highByte(bytesVal);
	bytesVal = bytesVal >> 8 * board;

	return(bytesVal);
}


// シフト出力
void write_shift_regs(byte value) {
	for (int j = 0; j < 7; j++) {
		// 送信中のlatchPinはグランド(LOW)レベル
		digitalWrite(pinOutputLatch, LOW);
		// シフト演算を使って点灯するLEDを選択しています
		shiftOut(pinOutputData, pinOutputClock, MSBFIRST, value);
		// 送信終了後latchPinをHIGHにする
		digitalWrite(pinOutputLatch, HIGH);
		//delay(100);
	}
}


//void setup()
//{
//    Serial.begin(9600);
//
//    pinMode(ploadPin, OUTPUT);
//    pinMode(clockEnablePin, OUTPUT);
//    pinMode(clockPin, OUTPUT);
//    pinMode(dataPin, INPUT);
//
//    digitalWrite(clockPin, LOW);
//    digitalWrite(ploadPin, HIGH);
//
//
//    pinValues = read_shift_regs();
//    display_pin_values();
//    oldPinValues = pinValues;
//}
//
//void loop()
//{
//    /* Read the state of all zones.
//    */
//    pinValues = read_shift_regs();
//
//    /* If there was a chage in state, display which ones changed.
//    */
//    if(pinValues != oldPinValues)
//    {
//        Serial.print("*Pin value change detected*\r\n");
//        display_pin_values();
//        oldPinValues = pinValues;
//    }
//
//    delay(POLL_DELAY_MSEC);
//}









