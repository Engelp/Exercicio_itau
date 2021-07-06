using System;

namespace Exercicio_itau
{
    static class Exercicio04
    {

        public static void Executar()
        {
            double salario, novo_salario, aumento;
            novo_salario = 0;
            
            Console.WriteLine("Informe seu salário: ");
            salario = Convert.ToDouble(Console.ReadLine());

            if (salario <= 2800)
            {
                novo_salario = salario + (salario * 0.2);
                Console.WriteLine("Percentual de aumento = 20%"); 
            }
            else if (salario > 2800 && salario <= 7000) 
            {
                novo_salario = salario + (salario * 0.15);
                Console.WriteLine("Percentual de aumento = 15%");
            }
            if (salario > 7000 && salario <= 15000) 
            {
                novo_salario = salario + (salario * 0.1);
                Console.WriteLine("Percentual de aumento = 10%");
                {
                }
                if (salario > 15000)
                {
                    novo_salario = salario + (salario * 0.05);
                    Console.WriteLine("Percentual de aumento = 5%");
                }
            }
            
            aumento = novo_salario - salario;
            Console.WriteLine("O valor do aumento foi: R$" + aumento);
            Console.WriteLine("O salário incial era: R$" + salario);
            Console.WriteLine("O novo salário será:  R$" + novo_salario);
        }
    }
}

