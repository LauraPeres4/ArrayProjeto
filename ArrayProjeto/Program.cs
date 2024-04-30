using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] nome = { "João", "Pedro", "Maria" };

            // Console.WriteLine("Digite um número de 0 a 2: ");

            // int i = int.Parse(Console.ReadLine());

            //  Console.WriteLine("O nome selecionado foi: " + nome[i]);

            //  Console.ReadKey();



            // string[] mes = {"Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho", "Julho", "Agosto", "Setembro", "Outubro", "Novembro", "Dezembro" };

            // Console.WriteLine("Digite o número de um mês: ");

            // int i = int.Parse(Console.ReadLine());

            // Console.WriteLine("O mês escolhido foi: " + mes[i - 1]);

            // Console.ReadKey();


            // string[] nome = new string[3];

            // Console.WriteLine("Digite o primerio nome: ");
            // nome[0] = Console.ReadLine();

            //  Console.WriteLine("Digite o segundo nome: ");
            // nome[1] = Console.ReadLine();

            // Console.WriteLine("Digite o terceiro: ");
            //  nome[2] = Console.ReadLine();

            // Console.WriteLine("Primerio nome: " + nome[0]);
            // Console.WriteLine("Segundo nome" + nome[1]);
            //  Console.WriteLine("Terceiro nome: " + nome[2]);

            // Console.ReadKey();



            String[] nome = new string[5];

            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Digite o nome do aluno: ");
                nome[i] = Console.ReadLine();
            }
            for (int j = 0; j <= 4; j++)
            {
                Console.WriteLine("Aluno: " + nome[j]);
            }
            
            Console.ReadKey();

        }
    }
}
