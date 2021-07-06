using System;

namespace Exercicio_itau
{
    static class Exercicio01
    {
        public static void Executar()
        {

            double nota1, nota2, media;

            Console.WriteLine("**** Exercício 01 ****");

            Console.WriteLine("Digite a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2) / 2;
            

            if ( media == 10) {
               Console.WriteLine("Aprovado por Distinção");
            } else if (media >= 7) {
                Console.WriteLine("Aprovado");
            } else {
                Console.WriteLine("Reprovado");
            }

        }
    }
}