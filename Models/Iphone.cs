using System;

namespace DesafioPOO.Models
{
    // A classe Iphone herda da classe abstrata Smartphone
    public class Iphone : Smartphone
    {
        // Construtor que chama o construtor da classe base (Smartphone)
        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria)
        {
        }

        // Sobrescrevendo o método abstrato da classe base
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo \"{nomeApp}\" pelo App Store no iPhone...");
        }
    }
}
