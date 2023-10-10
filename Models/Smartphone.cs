namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama
        public string IMEI { get; set; }
        public int Memoria { get; set; }
        public string Modelo { get; set; }
        public string Numero { get; set; }

        public Smartphone() { }

        public Smartphone(string IMEI, int memoria, string modelo, string numero)
        {
            this.IMEI = IMEI;
            Memoria = memoria;
            Modelo = modelo;
            Numero = numero;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}