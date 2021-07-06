using System;

namespace Exercicio_itau
{

    static class Exercicio06
    {
        public static void Executar()
        {
            int d;
            string dia;

            Console.WriteLine ("Informe um número de 1 à 7: ");
            d = Convert.ToInt16(Console.ReadLine());

            switch (d) {
            case 1 : 
                dia = "domingo";
                break;
            case 2:
                dia = "Segunda";
                break;
            case 3:
                dia = "Terça";
            break;
            case 4:
                dia = "Quarta";
            break;
            case 5:
                dia = "Quinta";
            break;
            case 6:
                dia = "Sexta";
            break;
            case 7:
                dia = "Sábado";
            break;
            default:
                dia = "Valor inválido";
                break; 
            }

            Console.WriteLine ("Dia da semana: " + dia);
        }
    }
}