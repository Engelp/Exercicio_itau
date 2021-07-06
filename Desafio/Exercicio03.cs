using System;

namespace Exercicio_itau
{
    static class Exercicio03
    {
        public static void Executar()
        {
                 double price1, price2, price3;

                 Console.WriteLine("**** Exercício 03 ****");

           Console.WriteLine("Digite o valor do primeiro produto: ");
           price1 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o segundo produto: ");
           price2 = Convert.ToDouble(Console.ReadLine());

           Console.WriteLine("Digite o terceiro produto: ");
           price3 = Convert.ToDouble(Console.ReadLine());

        if ( price1 < price2 && price1 < price3) {
            Console.WriteLine("O mais barato é o primeiro produto, no preço: R$" + price1 + " (Foi o produto escolhido)");
        } else if ( price2 < price3 && price2 < price1) {
            Console.WriteLine("O mais barato é o segundo produto, no preço: R$" + price2 + " (Foi o produto escolhido)");
        } else {
            Console.WriteLine("O mais barato é o terceiro produto, no preço: R$" + price3 + " (Foi o produto escolhido)");
        }

        }
    }
}