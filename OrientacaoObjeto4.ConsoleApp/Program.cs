using System;

namespace OrientacaoObjeto4.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Carro MediaPorLitro = new Carro();
            MediaPorLitro.KmInicial = 1000;
            MediaPorLitro.KmFinal = 1500;
            MediaPorLitro.consumo = 450;

            Console.WriteLine($"O veículo fez uma media de {MediaPorLitro.KmPorLitro():F2} Km/L");
            Console.ReadKey();
        }
    }
}
