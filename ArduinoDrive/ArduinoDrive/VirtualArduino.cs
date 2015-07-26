using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;
using System.Threading;

namespace ArduinoDrive {

	class VirtualArduino {

		private byte deviceAddress = 0x00;
		private const int TIMEOUT_MSEC = 3000;

		public enum PinMode : byte {
			INPUT = 0, OUTPUT = 1, INPUT_PULLUP = 2
		}

		public enum HL : byte {
			LOW = 0, HIGH = 1
		}

		public enum AD : byte {
			DIGITAL = 0, ANALOG = 1
		}

		private SerialPort serialPort;


		#region Arduinoアドレス割り付け
			const byte HREGIST_PIN_CONFIG = 0;              // ピン設定
			const byte HREGIST_PIN_DATA = 1;                // ピン入出力値
			const byte HREGIST_SHIFT_OUTPUT_DATA = 2;       // シフト出力値
			const byte HREGIST_SHIFT_INPUT_DATA = 3;        // シフト入力値
			const byte HREGIST_SOFTWARE_SERIAL = 4;         // ソフトウェアシリアル設定
			const byte HREGIST_EEP_INIT_DATA = 10;          // 制御変数メモリ
			const byte HREGIST_EEP_GENERAL_DATA = 11;       // 汎用メモリ
			const byte HREGIST_SOFTWARE_NO_VER = 98;        // ソフトウエア
			const byte HREGIST_INIT = 99;                   // 書き込むと初期化する領域

			const byte LREGIST_EEP_DEVICE_ADDRESS = 0;             // デバイスアドレス
			const byte LREGIST_EEP_BAUD_RATE_CODE = 1;             // (通常)シリアルのボーレート
			const byte LREGIST_EEP_SOFTWARE_SERIAL_BAUD_RATE = 2;  // ソフトウェアシリアルのボーレート
			const byte LREGIST_EEP_TIMEOUT_COUNT = 3;              // タイムアウトカウント値（×１０００）

		#endregion


		public VirtualArduino(SerialPort argPort) {

			this.serialPort = argPort;
			this.deviceAddress = 0;

			this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
		}

		public VirtualArduino(SerialPort argPort, byte argAddress) {

			this.serialPort = argPort;
			this.deviceAddress = argAddress;

			this.serialPort.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort_DataReceived);
		}




		/// <summary>
		/// 入出力・ＡＤモードを設定
		/// </summary>
		/// <param name="pin">ピン番号</param>
		/// <param name="mode">入出力モード</param>
		/// <param name="ad">ＡＤモード</param>
		public void setPinMode(byte pin, PinMode mode, AD ad) {

			byte[] byteWrite = new byte[8];

			byteWrite[0] = this.deviceAddress;
			byteWrite[1] = 0x06;
			byteWrite[2] = HREGIST_PIN_CONFIG;
			byteWrite[3] = pin;
			byteWrite[4] = (byte)mode;
			byteWrite[5] = (byte)ad;
			byteWrite[6] = 0xAA;
			byteWrite[7] = 0xAA;

			this.Write(byteWrite, 0, byteWrite.Length);

		}

		/// <summary>
		/// デジタル出力値をセット
		/// </summary>
		/// <param name="pin">ピン番号</param>
		/// <param name="digital">デジタル出力値</param>
		public void setPinValue(byte pin, HL digital) {

			byte[] byteWrite = new byte[8];

			byteWrite[0] = deviceAddress;
			byteWrite[1] = 0x06;
			byteWrite[2] = HREGIST_PIN_DATA;
			byteWrite[3] = pin;
			byteWrite[4] = 0x00;
			byteWrite[5] = (byte)digital;
			byteWrite[6] = 0xAA;
			byteWrite[7] = 0xAA;

			this.Write(byteWrite, 0, byteWrite.Length);

		}

		/// <summary>
		/// アナログ出力値をセット
		/// </summary>
		/// <param name="pin">ピン番号</param>
		/// <param name="value">アナログ出力値</param>
		public void setPinValue(byte pin, int value) {


			byte[] byteWrite = new byte[8];

			byteWrite[0] = deviceAddress;
			byteWrite[1] = 0x06;
			byteWrite[2] = HREGIST_PIN_DATA;
			byteWrite[3] = pin;
			byteWrite[4] = (byte)(value >> 8);			// 上位バイト
			byteWrite[5] = (byte)(value & 255);			// 下位バイト
			byteWrite[6] = 0xAA;
			byteWrite[7] = 0xAA;

			this.Write(byteWrite, 0, byteWrite.Length);

		}


		public int getPinValue(byte pin) {

			byte[] byteWrite = new byte[8];

			byteWrite[0] = deviceAddress;
			byteWrite[1] = 0x03;
			byteWrite[2] = HREGIST_PIN_DATA;
			byteWrite[3] = pin;
			byteWrite[4] = 0x00;			// 上位バイト
			byteWrite[5] = 0x01;			// 下位バイト
			byteWrite[6] = 0xAA;
			byteWrite[7] = 0xAA;

			int retValue = this.Write(byteWrite, 0, byteWrite.Length);

			return retValue;
		}


		ManualResetEvent mre = new ManualResetEvent(true);
		/// <summary>
		/// 通信データを出力
		/// </summary>
		/// <param name="buffer"></param>
		/// <param name="offset"></param>
		/// <param name="count"></param>
		/// <returns>読込みデータの[3][4]の値</returns>
		private int Write(byte[] buffer, int offset, int count) {

			int retValue = 0;

			// 他処理が終了するまで待機
			if (!mre.WaitOne(TIMEOUT_MSEC)) {

				readLength = 0;
				mre.Set();
				throw new TimeoutException("Arduinoからの応答がタイムアウトしました。");
			}

			// 他処理をブロック
			mre.Reset();

			this.readLength = 0;

			this.serialPort.Write(buffer, 0, count);

			/*
			Console.Write("\n<write>");
			for (int i = 0; i < count; i++) {
				Console.Write("   [" + i + "]=" + buffer[i]);
			}
			*/

			// 受信が完了するまで待機
			if (!mre.WaitOne(TIMEOUT_MSEC)) {

				readLength = 0;
				mre.Set();
				throw new TimeoutException("Arduinoからの応答がタイムアウトしました。");
			}

			retValue = this.readValue;
			return retValue;      
		}

		byte[] byteRead = new byte[MAX_READ_SIZE];
		int readLength = 0;
		const int MAX_READ_SIZE = 17;
		int readValue = 0;
		private void serialPort_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e) {

			int len = serialPort.Read(byteRead, this.readLength, byteRead.Length - this.readLength);
			readLength += len;

			if ( (byteRead[1] == 0x03 && readLength >= 7) || (byteRead[1] == 0x06 && readLength >= 8)) {
				/*
				Console.Write("\n<read>");
				for (int i = 0; i < readLength; i++) {
					Console.Write("   [" + i + "]=" + byteRead[i]);
				}
				Console.Write("  readLength=" + readLength);
				*/

				readValue = byteRead[3] * 256 + byteRead[4];

				mre.Set();	// 受信完了
			}
		}

		/// <summary>
		/// 送信から受信完了までにタイムアウトした場合の例外
		/// </summary>
		public class TimeoutException : Exception {

			public TimeoutException(String message)	: base(message) { }

		}
	}
}
