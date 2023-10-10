namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia()
        {

        }
        public Nokia(string IMEI, int memoria, string modelo, string numero) : base(IMEI: IMEI, memoria: memoria, modelo: modelo, numero: numero)
        {

        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} no Nokia");
        }
    }
}