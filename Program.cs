using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("### Testando Nokia ###");
        Nokia nokia = new Nokia("99999-0000", "Nokia Tijolão", "123456789", 64);
        nokia.Ligar();
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("Snake");

        Console.WriteLine();

        Console.WriteLine("### Testando iPhone ###");
        Iphone iphone = new Iphone("98888-1111", "iPhone 14 Pro", "987654321", 256);
        iphone.Ligar();
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("WhatsApp");
    }
}
