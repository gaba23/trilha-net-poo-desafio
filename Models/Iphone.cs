namespace DesafioPOO.Models
{
    // Herdando de Smartphone
    public class Iphone : Smartphone
    {
        // Construtor repassando os parâmetros para a classe base
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo método abstrato
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando aplicativo {nomeApp} no iPhone...");
        }
    }
}