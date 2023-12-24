using DesafioPOO.Models;

Console.WriteLine($"Iniciando Nokia!");

Smartphone nokia = new Nokia("12345", "Nokia", "12345", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Yt Music");

Console.WriteLine();

Console.WriteLine($"Iniciando iPhone!");

Smartphone iphone = new Nokia("67890", "iPhone", "67890", 256);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("LinkedIn");