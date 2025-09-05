using System;
using DesafioPOO.Models;

namespace DesafioPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone iphone = new Iphone("9891-9000", "iPhone 14", "IMEI98765", 128);
            Smartphone nokia = new Nokia("1234-5678", "Nokia 3310", "IMEI12345", 64);

            TestarSmartphone(iphone, "Instagram");
            Console.WriteLine();
            TestarSmartphone(nokia, "WhatsApp");

            Console.WriteLine("\nTestes finalizados!");
        }

        static void TestarSmartphone(Smartphone celular, string app)
        {
            Console.WriteLine($"=== Testando {celular.Modelo} ===");
            Console.WriteLine($"Número: {celular.Numero}");
            Console.WriteLine($"Modelo: {celular.Modelo}");
            Console.WriteLine($"IMEI: {celular.Imei}");
            Console.WriteLine($"Memória: {celular.Memoria}GB");

            celular.Ligar();
            celular.ReceberLigacao();
            celular.InstalarAplicativo(app);
        }
    }
}
