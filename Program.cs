using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "(11) 99545-3112", modelo: "Nokia G60", imei: "354948230", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Notion");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "(11) 99545-3112", modelo: "Iphone 15 Pro Max", imei: "39210912", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("Github");

