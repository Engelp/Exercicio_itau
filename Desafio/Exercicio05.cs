using System;

namespace Exercicio_itau
{
    static class Exercicio05
    {
        public static void Executar()
        {
            double bruto, liquido, desconto, hora, htrab, perct, perct2 = 0.05, perct3 = 0.1, perct4 = 0.2;
            liquido = 0;
            perct = 0;
            
            Console.WriteLine("Informe o valor da sua hora trabalhada: ");
            hora = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de horas trabalhadas: ");
            htrab = Convert.ToDouble(Console.ReadLine());

            bruto = hora * htrab;

            if (bruto <= 2000)
            { 
                liquido = bruto;
                perct = 0;
            }
            else if (bruto <= 5000) 
            {
                liquido = bruto - (bruto * perct2);
                perct = perct2;
            }
            else if (bruto <= 7500)
            {
                liquido = bruto - (bruto * perct3);
                perct = perct3;
            } else {
                    liquido = bruto + (bruto * perct4); 
                    perct = perct4;
                    }
                
            
            desconto = bruto - liquido ;
            //perct = Convert.ToDouble(())
            Console.WriteLine("Salário Bruto: (" + hora + " * " + htrab + ")                              : R$   " + bruto);
            Console.WriteLine("(-) IR (" + (perct * 100) +"%)                                           : R$   " +  (bruto * perct));
            Console.WriteLine("(-) INSS ( 10%)                                        : R$   " + (bruto * 0.1));
            Console.WriteLine("FGTS (11%)                                             : R$   " + (bruto * 0.11));
            Console.WriteLine("Sindicato (3%)                                         : R$   " + (bruto * 0.03));
            Console.WriteLine("Total de descontos                                     : R$   " + ((bruto * 0.24 + (bruto * perct))));                                   
            Console.WriteLine("Salário líquido                                        : R$   " + (liquido - ((bruto * 0.24)+(bruto*perct))));
        }
    }
}