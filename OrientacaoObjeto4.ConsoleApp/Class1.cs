using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto4.ConsoleApp
{
    internal class Carro
    {
        public double KmInicial;
        public double KmFinal;
        public double consumo;
        public double KmPorLitro()
        {
            double ValorFinal = (KmFinal - KmInicial) / consumo;
            return ValorFinal;
        }
    }
}
