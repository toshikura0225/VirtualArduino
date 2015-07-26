#include <EEPROM.h>

const byte HREGIST_EEP_INIT_DATA = 10;          // 制御変数メモリ
const byte LREGIST_EEP_BAUD_RATE_CODE = 1;             // (通常)シリアルのボーレート

void setup() {
  
  delay(1000);
  
  
  Serial.begin(9600);
  
  
  for (int i=0; i<10; i++) {
    Serial.println(EEPROM.read(two2one(HREGIST_EEP_INIT_DATA, i)),OCT);
  }
  
  // ボーレート
  EEPROM.write(two2one(HREGIST_EEP_INIT_DATA, LREGIST_EEP_BAUD_RATE_CODE), 0);
  
}


void loop() {
  Serial.print("initialize comleted");
  delay(100000);
}


int two2one(byte b1 ,byte b2) { return (b1 * 256 + b2); };
