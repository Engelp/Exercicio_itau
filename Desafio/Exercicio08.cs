using System;

namespace desafio
{
    class Exercicio08
    {
        public static void Executar()
        {
            
            Console.WriteLine("Informe um lado do triangulo ");
            int lado1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o outro lado lado do triangulo ");
            int lado2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o últim lado lado do triangulo ");
            int lado3 = Convert.ToInt32(Console.ReadLine());


            
           bool ehTriangulo = (lado1 <= lado2 + lado3) && (lado2 <= lado1 + lado3) && (lado3 <= lado1 + lado2);

            if (ehTriangulo)
            {
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Triângulo equilátero");
                }
                else
                {
                    if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                    {
                        Console.WriteLine("Triangulo isósceles");
                    }
                    else
                    {
                        Console.WriteLine("Triângulo escaleno");
                    }
                }
            }
            else 
            {
                Console.WriteLine("Não é um triangulo.");
            }
        }
    }

}