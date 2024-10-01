using DesafioPOO.Models;

Console.WriteLine("IPHONE");
Smartphone iphone = new Iphone("8569-2147", "Iphone14", "123456", 64);
iphone.Ligar();
iphone.InstalarAplicativo("Ifood");

Console.WriteLine("__________________________");

Console.WriteLine("NOKIA");
Smartphone nokia = new Nokia("8569-1234", "Octa-Core ", "32156", 32);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Burger King");