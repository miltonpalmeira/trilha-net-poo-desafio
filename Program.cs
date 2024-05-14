using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("-------------- EXEMPLO COM NOKIA --------------------");
Smartphone nokia = new Nokia(numero: "123456", modelo: "Nokia ABC-YZ", imei: "123456789", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("-------------- EXEMPLO COM Iphone --------------------");

Smartphone iphone = new Iphone(numero: "654321", modelo: "Iphone S123", imei: "987654321", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Linkedin");