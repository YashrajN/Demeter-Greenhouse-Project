/*
   Writen by: Andrew Castro and Yahsraj Nagpal
   Written for: Mr.Kolch
   Subject: TER4M1 - 01
   Date: January 17th 2020
   Description: Recieves a constructed value from Visual Studios and then deconstructes it into values that tell the arduino specific sets of instructions.
*/


#include <DHT.h> // library for temperature and humidity sensor

String daily; // value representing the amount times to water the plant everyday (each watering cycle is 4 seconds)
//String frequency;
//String duration;
String light; // amount of hours of light everyday
String direct; // determines if light will be direct (constant) or indirect (blinking)
String temperature; // 2 digit value that determines the temperature of the greenhouse
String readValue; // constructed value that is sent from the Visual Studios form
boolean condition = false; // boolean that determines when to deconstruct readValue
boolean heatingPeriod = true; // boolean that makes it so the heater has time to heat up
int pump = 13; // pump pin
int fan = 11; // fan pin
int heater = 12; // heater pin
int led = 7; // led pin
int sensor = 6; // sensor pin
int sensorType = DHT22; // type of sensor
int flag; // acts as a counter to determine when to activate the pump and how many times it has gone
int dayLength = 30000; // conversion from days to seconds reference
int ledState = LOW;///////////////////////
long beginTime; // time of program starting
long presentTime; // curent time of the program
long changedTime; // determines the time elapsed

DHT dht(sensor, sensorType); // defines library for sensor

void setup() {

  Serial.begin(9600);
  pinMode(pump, OUTPUT);
  pinMode(fan, OUTPUT);
  pinMode(heater, OUTPUT);
  pinMode(led, OUTPUT);

  dht.begin();

}

void loop() {

  float t; //the temperature variable is declared

  beginTime = millis(); // sets the value to the current time of the day to use as reference when determining other values ******** starts the clock at zero time

  t = dht.readTemperature(); //the temperature is read from the sensor

  // checks for a value from Visual Studios
  if (Serial.available() > 0) {

    readValue = Serial.readString(); // sets value to value sent from Visual Studios
    condition = true; // allows the deconstuction of readValue
    beginTime = millis(); // starts the clock at zero time
  }

  daily = readValue.substring(0, 2);
  light = readValue.substring(2, 4);
  direct = readValue.substring(4, 6);
  temperature = readValue.substring(6);
  // deconstucts readValue

  flag = 0; // set watering flag
  presentTime = millis(); // records the current time
  changedTime = presentTime - beginTime; // how much time as elapsed
  // refreshes changedTime

  // checks if values are not composed of nulls
  if (condition == true) {

    int intdaily = dayLength / daily.toInt(); // makes it so the more times daily means a smaller gap inbetween each water cycle
    double intlight = ((light.toDouble()) / 24) * dayLength; // hour to second
    float doubleTemp = (temperature.toInt()) * 1.0; // determines the temperature in the form of a float

    //********************************** for environment temperature greater than request

    presentTime = millis(); // records the current time
    changedTime = presentTime - beginTime; // how much time as elapsed
    // refreshes changedTime

    // checks if the temp is greater then the desired temp and if the day is over
    while (t > doubleTemp && changedTime < dayLength) {

      digitalWrite(fan, HIGH);

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed
      // refreshes changedTime

      // checks if light should be direct and checks if the period of time the light should be on has not passed
      if (direct == "10" && changedTime < intlight) {
        digitalWrite(led, HIGH);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      //Checks if light should be direct and checks if the period of time the light should be on has passed
      if (direct == "10" && changedTime > intlight) {
        digitalWrite(led, LOW);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed
      // refreshes changedTime

      // checks if light should be indirect and checks if the period of time the light should be on has passed
      if (direct == "20" && changedTime < intlight) {
        digitalWrite(led, HIGH);
        delay (1000);
        digitalWrite(led, LOW);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks if light should be indirect and checks if the period of time the light should be on has passed
      if (direct == "20" && changedTime > intlight) {
        digitalWrite(led, LOW);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed
      // refreshes changedTime

      // checks the status of the pump according to the flag (the number of times it has turned on)
      if (changedTime < intdaily && flag == 0) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 1;
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks the status of the pump according to the flag (the number of times it has turned on) and what time of day it is
      if (changedTime > intdaily && changedTime < intdaily * 2 && flag == 1) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 2;
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks the status of the pump according to the flag (the number of times it has turned on) and what time of day it is
      if (changedTime > intdaily * 2 && changedTime < intdaily * 3 && flag == 2) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 3;
      }

      t = dht.readTemperature();

    }

    digitalWrite(fan, LOW);
    delay(500);

    //********************************** for environment temperature less than request

    presentTime = millis(); // records the current time
    changedTime = presentTime - beginTime; // how much time as elapsed

    // checks if the temp is less then the desired temp and if the day is over
    while (t < doubleTemp && changedTime < dayLength) {

      digitalWrite(heater, HIGH);

      // a 4 second period of time that allows the heating coil to begin heating up
      if (heatingPeriod) {

        delay(4000);

        heatingPeriod = false;

      }

      digitalWrite(fan, HIGH);

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks if light should be direct and checks if the period of time the light should be on has not passed
      if (direct == "10" && changedTime < intlight) {
        digitalWrite(led, HIGH);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      //Checks if light should be direct and checks if the period of time the light should be on has passed
      if (direct == "10" && changedTime > intlight) {
        digitalWrite(led, LOW);
      }

      // checks if light should be indirect and checks if the period of time the light should be on has passed
      if (direct == "20" && changedTime < intlight) {
        digitalWrite(led, HIGH);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks if light should be indirect and checks if the period of time the light should be on has passed
      if (direct == "20" && changedTime > intlight) {
        digitalWrite(led, LOW);
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks the status of the pump according to the flag (the number of times it has turned on)
      if (changedTime < intdaily && flag == 0) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 1;
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks the status of the pump according to the flag (the number of times it has turned on) and what time of day it is
      if (changedTime > intdaily && changedTime < intdaily * 2 && flag == 1) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 2;
      }

      presentTime = millis(); // records the current time
      changedTime = presentTime - beginTime; // how much time as elapsed

      // checks the status of the pump according to the flag (the number of times it has turned on) and what time of day it is
      if (changedTime > intdaily * 2 && changedTime < intdaily * 3 && flag == 2) {
        digitalWrite(pump, HIGH);
        delay(4000);
        digitalWrite(pump, LOW);
        flag = 3;
      }

      t = dht.readTemperature();

    }

    digitalWrite(fan, LOW);
    digitalWrite(heater, LOW);




    // ******************************** Repeat the daily cycle
    presentTime = millis(); // records the current time
    changedTime = presentTime - beginTime; // how much time as elapsed
    if (changedTime > dayLength + 1) {
      beginTime = millis(); // starts the clock at zero time
      flag = 0;
    }


  }
}
