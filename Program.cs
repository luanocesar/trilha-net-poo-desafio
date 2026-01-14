using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "980801212", modelo : "NK-001", imei : "8000000001", memoria : 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone");
Smartphone iphone = new Iphone(numero : "980811414", modelo : "IP20", imei : "8000000002", memoria : 128);
iphone.Ligar();
nokia.InstalarAplicativo("Telegram");