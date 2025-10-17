using System;
using DesafioPOO.Models;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Smartphone Nokia:");
        Smartphone nokia = new Nokia(numero: "99999-1111", modelo: "Nokia Tijolão", imei: "111111111111111", memoria: 64);
        nokia.Ligar();
        nokia.InstalarAplicativo("WhatsApp");

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Smartphone iPhone:");
        Smartphone iphone = new Iphone(numero: "99999-2222", modelo: "iPhone 15", imei: "222222222222222", memoria: 256);
        iphone.ReceberLigacao();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Testes concluídos com sucesso!");
    }
}
