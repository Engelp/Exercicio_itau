using System;

namespace Exercicio_itau
{
    static class Exercicio10
    {
        public static void Executar()
        {

            double tempF, tempC;

            Console.WriteLine("Informe a temperatura em Fahrenheit: ");
            tempF = Convert.ToDouble(Console.ReadLine());

            tempF = (tempF - 32) / 9;
            tempC = tempF * 5;

            Console.WriteLine("A temperatura informar em Celsius é = " + tempC + " C°");

        }
    }
}