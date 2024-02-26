using System.Security.Cryptography.X509Certificates;

namespace DesafioPOO.Models
{
    public class Iphone : Smartphone
    {
        public Iphone (string numero, string modelo, string imei, int memoria ) : base (numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine ($"Neste momento o aplicativo {nomeApp} está sendo instalado no Iphone");
        }
    
    }
}


