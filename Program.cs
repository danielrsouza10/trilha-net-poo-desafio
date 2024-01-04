using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nokia = new Nokia("(62) 8888-7777");
Console.WriteLine(nokia.Numero);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");
nokia.Modelo = "1100";
Console.WriteLine(nokia.Modelo);

Console.WriteLine("-----------------------------");

Iphone iphone = new Iphone("(63) 9999-8888");
Console.WriteLine(iphone.Numero);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("youtube");
iphone.Modelo = "13 Pro Max";
Console.WriteLine(iphone.Modelo);
