int redPin = D6;
int greenPin = D7;
int bluePin = D8;

void setup()
{
  // declare the serial comm at 9600 baud rate
  Serial.begin(9600);
 
  // output pins
  pinMode(redPin, OUTPUT); // red
  pinMode(greenPin, OUTPUT); // green
  pinMode(bluePin, OUTPUT); // blue
  digitalWrite(redPin, HIGH);
  digitalWrite(greenPin, HIGH);
  digitalWrite(bluePin, HIGH);
}
 
void loop()
{
  // call the returned value from GetFromSerial() function
  switch(GetFromSerial())
  {
  case '1':
    digitalWrite(redPin, LOW);
    break;
  case '2':
    digitalWrite(redPin, HIGH);
    break;
  case '3':
    digitalWrite(greenPin, LOW);
    break;
  case '4':
    digitalWrite(greenPin, HIGH);
    break;
  case '5':
    digitalWrite(bluePin, LOW);
    break;
  case '6':
    digitalWrite(bluePin, HIGH);
    break;
  }
}
 
// read the serial port
int GetFromSerial()
{
  while (Serial.available()<=0) {
  }
  return Serial.read();
}
