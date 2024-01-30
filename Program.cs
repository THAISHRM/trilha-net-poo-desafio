using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "911111111",  modelo: "Modelo N10", imei: "090909", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Twitter");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "922222222",  modelo: "Modelo 15", imei: "101010", memoria: 256);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");