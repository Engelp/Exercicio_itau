using System;

namespace Exercicio_itau
{
    static class Exercicio02
    {
       public static void Executar()
       {
           double num1, num2, num3;

           Console.WriteLine("**** Exercício 02 ****");

           Console.WriteLine("Digite o primeiro número: ");
           num1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o segundo número: ");
           num2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o terceiro número: ");
           num3 = Convert.ToDouble(Console.ReadLine());

        if ( num1 < num2 && num1 < num3) {
            Console.WriteLine("O primeiro número é o menor: " + num1);
        } else if ( num2 < num3 && num2 < num1) {
            Console.WriteLine("O segundo número é o menor: " + num2);
        } else {
            Console.WriteLine("O terceiro número é o menor: " + num3);
        }

         if ( num1 > num2 && num1 > num3) {
            Console.WriteLine("O primeiro número é o maior: " + num1);
        } else if ( num2 > num3 && num2 > num1) {
            Console.WriteLine("O segundo número é o maior: " + num2);
        } else {
            Console.WriteLine("O terceiro número é o maior: " + num3);
        }

       }
    }
}