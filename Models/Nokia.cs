using System.Runtime.CompilerServices;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia (string numero, string modelo, string imei, int memoria) : base (numero, modelo, imei, memoria)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine ($"Neste momento o aplicativo {nomeApp} está sendo instalado no Nokia");
        }
    }
}
