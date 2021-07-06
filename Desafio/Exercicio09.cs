using System;

namespace Exercicio_itau
{
    static class Exercicio09
    {
        public static void Executar()
        {
            double nota1, nota2, nota3, media;

            Console.WriteLine("Insira a primeira nota: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a segunda nota: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Insira a terceira nota: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (((nota1 * 2) + (nota2 * 3) + (nota3 * 5))) / 10;

            Console.WriteLine("A média ponderada do aluno é: " + media);
            
        }
    }
}