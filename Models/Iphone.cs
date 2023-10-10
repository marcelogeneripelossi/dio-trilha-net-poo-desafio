namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {

        public Iphone()
        {

        }

        public Iphone(string IMEI, int memoria, string modelo, string numero) : base(IMEI: IMEI, memoria: memoria, modelo: modelo, numero: numero)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Iphone");
        }

    }
}