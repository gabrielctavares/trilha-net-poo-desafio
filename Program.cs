using DesafioPOO.Models;


Nokia telefone = new Nokia("99291", "Nokia 2201", "123456789", 16);
Iphone iphone = new Iphone("99231", "Iphone 16", "987654321", 256);

telefone.Ligar();
telefone.ReceberLigacao();
telefone.InstalarAplicativo("Whatsapp");


iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

// TODO: Realizar os testes com as classes Nokia e Iphone