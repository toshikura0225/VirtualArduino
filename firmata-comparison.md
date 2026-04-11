# VirtualArduino vs Firmata 機能比較

## Firmataで代替できる機能

| VirtualArduino機能 | Firmata対応 | 備考 |
|---|---|---|
| デジタルI/O (read/write) | **完全対応** | 標準Firmata |
| アナログ入力 (ADC) | **完全対応** | 標準Firmata |
| PWM出力 | **完全対応** | 標準Firmata |
| ピンモード設定 | **完全対応** | INPUT/OUTPUT/INPUT_PULLUP含む |
| I2C (TWI) | **完全対応** | 標準Firmataに内蔵 |
| SPI | **対応** | ConfigurableFirmata + FirmataSPIプラグインが必要 |

## Firmataでは代替が難しい機能

| VirtualArduino機能 | Firmata対応 | 問題点 |
|---|---|---|
| **ワンパルスモード** (LHL/HLH) | **未対応** | Firmataにパルス生成機能なし |
| **シフトレジスタ制御** (74HC595/165) | **部分対応** | ConfigurableFirmataでプラグイン実装が必要 |
| **SoftwareSerial** | **未対応** | Firmataに標準的な実装なし |
| **EEPROM読み書き** | **未対応** | 設定永続化ができない |
| **デバイスアドレス** (Modbus的なマルチデバイス) | **未対応** | Firmataは1シリアル=1デバイス前提 |
| **Modbusプロトコル互換性** | **完全非互換** | FirmataはMIDIベースの別プロトコル |

## 総評

**部分的には代替可能ですが、完全置き換えは困難です。**

### 代替しやすいケース
- 基本的なGPIO制御、センサー読み取り、PWMだけを使う場合
- Python (`pyFirmata`) やNode.js (`johnny-five`) のエコシステムを活用したい場合

### 代替が難しいケース
- **ワンパルスモード**は独自機能で相当物がない
- **Modbus RTUプロトコル互換性**が必要な既存システムがある場合
- **複数デバイスのバス共有**が必要な場合
- **EEPROM設定永続化**（ボーレート・デバイスアドレス保存）が必要な場合

## VirtualArduinoのプロトコル概要（参考）

VirtualArduinoは独自のModbus RTU風8バイトパケットを使用：

```
Byte 0: デバイスアドレス (デフォルト 0x01)
Byte 1: ファンクションコード (0x03=Read, 0x06=Write)
Byte 2: レジスタアドレス上位バイト
Byte 3: レジスタアドレス下位バイト
Byte 4: データ上位バイト
Byte 5: データ下位バイト
Byte 6-7: CRC-16
```

### レジスタアドレスマップ

| 上位バイト (種別) | 機能 |
|---|---|
| 0x00 | PIN_CONFIG (ピン設定) |
| 0x01 | PIN_DATA (デジタル/アナログ読み書き) |
| 0x02 | SHIFT_OUTPUT_DATA (シフト出力レジスタ) |
| 0x03 | SHIFT_INPUT_DATA (シフト入力レジスタ) |
| 0x04 | SOFTWARE_SERIAL (ソフトウェアシリアル設定) |
| 0x05 | SPI操作 |
| 0x06 | I2C/TWI操作 |
| 0x0A | EEP_INIT_DATA (EEPROM初期設定) |
| 0x0B | EEP_GENERAL_DATA (汎用EEPROMストレージ) |
| 0x0C | COM (delay等汎用コマンド) |
| 0x62 | SOFTWARE_NO_VER (ファームウェアバージョン照会) |
| 0x63 | INIT (リセット/初期化) |
