using DesafioPOO.Models;


Console.WriteLine(" Celular Nokia");
Nokia nokia = new Nokia("11987915018","UAUTECNO","458164485-x",256);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Wild Rift");

Console.WriteLine(" Celular Iphone");
Iphone iphone = new Iphone("11974602849","Iphone 11","54845818-y", 256 );
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Free Fire");