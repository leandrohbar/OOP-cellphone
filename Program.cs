using DesafioPOO.Models;

Nokia nokia = new Nokia(numero:"123456789", modelo:"Nokia 3310", imei:"123456789", memoria:16);
Iphone iphone = new Iphone(numero:"987654321", modelo:"Iphone 12", imei:"987654321", memoria:128);

Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");

Console.WriteLine();

Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");
