using System;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        // Propriedades de acordo com o diagrama
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string Imei { get; set; }
        public int Memoria { get; set; }

        // Construtor completo
        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }

        // Métodos comuns a todos os smartphones
        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        // Método abstrato que será sobrescrito pelas classes filhas
        public abstract void InstalarAplicativo(string nomeApp);
    }
}
