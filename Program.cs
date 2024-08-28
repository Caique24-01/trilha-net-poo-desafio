using DesafioPOO.Models;

Iphone iphone = new Iphone("(11)940028922", "Iphone 16", "23443759603945", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Instagram");
iphone.ReceberLigacao();
Console.WriteLine("");
Nokia nokia = new Nokia("(11)997650394", "Nokia G60 5G", "2334567830495823", 256);
nokia.Ligar();
nokia.InstalarAplicativo("Shopee");
nokia.ReceberLigacao();