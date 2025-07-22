using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "123456789", modelo: "Modelo1", imei: "1234", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "987654321", modelo: "Modelo2", imei: "5678", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

// TODO: Realizar os testes com as classes Nokia e Iphone