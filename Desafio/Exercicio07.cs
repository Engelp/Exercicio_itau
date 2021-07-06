using System;

namespace Exercicio_itau
{
    static class Exercicio07
    {
        public static void Executar()
        {
            string situacao = "";

            Console.WriteLine("Digite sua primeira nota"); 
            float nota1 = float.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite sua segunda nota"); 
            float nota2 = float.Parse(Console.ReadLine());

            float media = (nota1 + nota2) / 2;

             if(media >= 9.0 && media <= 10.0){ 
                situacao = "A"; 
            }
            else if(media >=7.5 && media < 9.0)
            { 
                situacao = "B";
            }
            else if(media >=6.0 && media < 7.5)
            {
                situacao = "C";
            }
            else if(media >= 4.0 && media < 6.0)
            {
                situacao = "D";
            }
            else if(media < 4.0 )
            {
                situacao = "E";
            }

            Console.WriteLine("Média: " + media); 
            Console.WriteLine("Conceito: " + situacao);
  
        }
    }
}