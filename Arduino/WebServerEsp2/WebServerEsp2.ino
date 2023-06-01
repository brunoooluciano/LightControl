#include <ESP8266WiFi.h>
#include <ESP8266WebServer.h>

const char* ssid = "CLARO_2GFF44C2";
const char* password = "B8FF44C2";

//Define static IP
IPAddress localIp(192, 168, 0, 10);
IPAddress gateway(192, 168, 0, 1);
IPAddress subnet(255, 255, 0, 0);

ESP8266WebServer server(80);

//Define consts 
int lampD4 = D4; 
int lampD8 = D8; 

void handleRoot() {
  //HomePage
  String response = "<h1>Bonsoir</h1><p>| Use 'on?lamp=D4' or 'off?lamp=D4' to request |<br>| you can use lamp 'D4' and 'D8' |</p>";
  server.send(200, "text/html", response);
}

void handleOn() {
  //turn on
  String lamp = server.arg("lamp");
  String response;

  if (lamp == "D4") {
    digitalWrite(lampD4, LOW);
    response = "<h1>D4_on</h1>";
  } else if (lamp == "D8") {
    digitalWrite(lampD8, LOW);
    response = "<h1>D8_on</h1>";
  } else {
    response = "<h1>Invalid</h1>";
  }

  server.send(200, "text/html", response);
}

void handleOff() {
  //turn off
  String lamp = server.arg("lamp");
  String response;

  if (lamp == "D4") {
    digitalWrite(lampD4, HIGH);
    response = "<h1>D4_off</h1>";
  } else if (lamp == "D8") {
    digitalWrite(lampD8, HIGH);
    response = "<h1>D8_off</h1>";
  } else {
    response = "<h1>Invalid</h1>";
  }

  server.send(200, "text/html", response);
}
///////////////////

void setup() {
  Serial.begin(115200); //bits per second
  pinMode(lampD4, OUTPUT); 
  pinMode(lampD8, OUTPUT);
  digitalWrite(lampD4, LOW);
  digitalWrite(lampD8, LOW);
  WiFi.config(localIp, gateway, subnet);//
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }


  Serial.println("Connected to WiFi");
  Serial.print("IP address: ");
  Serial.println(WiFi.localIP());

  server.on("/", handleRoot);
  server.on("/on", handleOn);
  server.on("/off", handleOff);
  server.begin();

  Serial.println("Web server started");

}

void loop() {
  server.handleClient();
}


/*

// Método de comunicação via serial que também pode ser utilizado para conectar a aplicação windows forms do CSharp

    void Lampada()
    {
      if(digitalRead(lampPin), == HIGH)
      {
        digitalWrite(lampPin, LOW);
      }
      else
      {
        digitalWrite(lampPin, HIGH);
      }
    }
  void loop(){

    if(Serial.available()) // Se a comunicação Serial estive disponível..
    {
      char op = Serial.read(); // Leia a op (Opção) da Serial.
      
      if (op == '1')
      {
        Lampada();
      }
    }
  }
*/
