
using System;

namespace exerciciofix4
{
    class ConversorDeMoeda
    {
        public static double Iof = 6.38 ;

        public static double ValorASerPago(double quantia, double cotacao){
            double total = quantia * cotacao;
            return total + (total * Iof / 100.0);
        }
    }
}
