using DesafioPOO.Models;

Iphone celular1 = new Iphone (numero: "900000000", modelo: "Iphone", imei: "1111111111", memoria: 16);
Nokia celular2 = new Nokia (numero: "911111111", modelo: "Nokia", imei: "2222222222", memoria: 8);

Console.WriteLine ("TESTE IPHONE");
Console.WriteLine ($"O número do iphone é {celular1.Numero}");
celular1.Ligar("Gabriel");
celular1.ReceberLigacao("Gustavo");
celular1.InstalarAplicativo("Tiktok");

Console.WriteLine ("");

Console.WriteLine ("TESTE NOKIA");
Console.WriteLine ($"O número do nokia é {celular2.Numero}");
celular2.Ligar("Gabriel");
celular2.ReceberLigacao("Gustavo");
celular2.InstalarAplicativo("Tiktok");
