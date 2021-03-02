using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cálculo de IMC");

            Console.WriteLine("Digite abaixo o seu peso em Kg");
            string Peso = Console.ReadLine();
            Console.WriteLine("Digite abaixo a sua Altura em m");
            string Altura = Console.ReadLine();
            string Mensagem;

            double IMC = Math.Round(double.Parse(Peso) / Math.Pow(double.Parse(Altura), 2), 2);

            if (IMC < 16)
            {
                Mensagem = IMC + " - Magreza Severa";
                Console.BackgroundColor = ConsoleColor.DarkGray;
            }
            else if (IMC < 17)
            {
                Mensagem = IMC + " - Magreza Moderada";
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (IMC < 18.5)
            {
                Mensagem = IMC + " - Magreza Leve";
                Console.BackgroundColor = ConsoleColor.White;
            }
            else if (IMC < 25)
            {
                Mensagem = IMC + "- Peso Normal";
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (IMC < 30)
            {
                Mensagem = IMC + "- Sobrepeso";
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (IMC < 35)
            {
                Mensagem = IMC + "- Obesidade Classe I";
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else if (IMC < 40)
            {
                Mensagem = IMC + "- Obesidade Classe II";
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else
            {
                Mensagem = IMC + "- Obesidade Classe III";
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("O seu IMC é " + Mensagem);
            Console.ReadLine();


        }
    }
}
