  int in1 = 7;

void setup() {
  // put your setup code here, to run once:
Serial.begin(9600);
pinMode(in1,OUTPUT);
digitalWrite(in1,HIGH);
}

void loop() {
  while(Serial.available()>0){
    switch(Serial.read()){
      case '0':
        digitalWrite(in1,HIGH);
        break;
      case '1':
        digitalWrite(in1,LOW);
        delay(500);
        digitalWrite(in1,HIGH);
        break;
    }
  }
}
