namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        protected string Modelo { get; set; }
        protected string Imei { get; set; }
        protected int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        public void Ligar(string pessoa)
        {
            Console.WriteLine($"Ligando para {pessoa}.");
        }

        public void ReceberLigacao(string pessoa)
        {
            Console.WriteLine($"Recebendo ligação de {pessoa}.");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
