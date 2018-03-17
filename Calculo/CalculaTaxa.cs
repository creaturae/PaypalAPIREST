using System;

namespace Calculo
{
    public static class CalculaTaxa
    {

        /// <summary>
        ///  Recebe os valores e faz o calculo do valor a receber.
        /// </summary>
        /// <param name="valorPay">valor pago</param>
        /// <param name="moeda">código da moeda. USD, BRL ou EUR</param>
        /// <returns></returns>
        public static double PaypalParm(double valorPay, string moeda )
        {
            double tax;
            double taxFixo;

            tax = (7.4 / 100);
            taxFixo = 0.30;

            // BRL
            if (moeda == "BRL")
            {
                tax = (4.99 / 100);
                taxFixo = 0.60;
            }
            // GBP
            if (moeda == "GBP")
            {
                tax = (7.4 / 100);
                taxFixo = 0.20;
            }
            // EUR
            if (moeda == "EUR")
            {
                tax = (7.4 / 100);
                taxFixo = 0.35;
            }
            // USD
            if (moeda == "USD")
            {
                tax = (7.4 / 100);
                taxFixo = 0.30;
            }

            else
            {
                moeda = "USD";
            }


            return Math.Round((valorPay - (valorPay * tax) - taxFixo), 2);
        }

    }
}
