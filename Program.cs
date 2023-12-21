using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "81999999999", modelo: "Nokia Brick Plus", imei: "1212112", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Instagram");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "81988888888", modelo: "Iphone 0 Batery", imei: "5757575", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Facebook");