using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_para_pratica
{
    public class Andares : Elevador
    {
        public string Inicializa()
        {
            Console.WriteLine($"Digite a quantidade total de andares do prédio(desconsidere o térreo): ");
            TotalAndares = int.Parse(Console.ReadLine());

            Console.WriteLine(@$"
Digite a quantidade máxima de pessoas que o elevador suporta: ");
            Capacidademax = int.Parse(Console.ReadLine());
            return "";
        }


        public string entrar()
        {
            if (PessoasPresentes >= Capacidademax)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
O elevador atingiu sua máxima capacidade!");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Andares.PessoasPresentes++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Clear();
                Console.WriteLine(@$"
Uma pessoa entrou no elevador!
");
                Console.ResetColor();

                Console.WriteLine($"Aperte enter para prosseguir!");

                Console.ReadKey();
                Console.Clear();
            }

            return "";
        }



        public string sair()
        {
            if (PessoasPresentes <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
Ninguém está dentro do elevador neste momento!");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Andares.PessoasPresentes--;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(@$"
Uma pessoa saiu no elevador!
");
                Console.ResetColor();

                Console.WriteLine($"Aperte enter para prosseguir!");

                Console.ReadKey();
                Console.Clear();
            }
            return "";
        }


        public string subir()
        {
            if (AndarAtual >= TotalAndares)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
O elevador chegou no último andar!");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Andares.AndarAtual++;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@$"
O elevador subiu 1 andar!
");
                Console.ResetColor();

                Console.WriteLine($"Aperte enter para prosseguir!");

                Console.ReadKey();
                Console.Clear();
            }
            return "";
        }



        public string descer()
        {
            if (AndarAtual <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(@$"
O elevador está no térreo!");
                Console.ResetColor();
                Console.ReadKey();
            }
            else
            {
                Andares.AndarAtual--;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@$"
O elevador desceu 1 andar!
");
            Console.ResetColor();

            Console.WriteLine($"Aperte enter para prosseguir!");

            Console.ReadKey();
            Console.Clear();
            }
            
            return "";
        }
    }
}