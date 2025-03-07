using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_Projeto_C_Sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, num;

            for (; ; )
            { //ciclo infinito for (;;)

                opcao = Utilidades.menu();
                if (opcao == 0) break;// Se for 0 sai do ciclo
                try//Valida se é um número
                {
                    switch (opcao)//Valida a opção
                    {
                        case 1:
                            Console.WriteLine("Execicío 1: Dobro");
                            Console.Write("Escolha um número: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O dobro de {num} = {Utilidades.dobro(num)}");
                            break;

                        case 2:
                            Console.WriteLine("Execicío 2: Selos");
                            Console.Write("Escolha um número: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{Utilidades.selos(num)}");

                            break;
                        case 3:
                            Console.WriteLine("Execicío 3: Paridade");
                            Console.Write("Escolha um número: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O número {num} é {Utilidades.paridade(num)}");
                            break;

                        default:
                            Console.WriteLine("Opção inválida, escolha outra opção");//Mensagem de erro
                            break;
                    }
                }
                catch (Exception erro) //Da erro se o utilizador introduzir um caracter
                {
                    Console.WriteLine(erro.Message);//Mensagem de erro
                }
                Console.ReadLine();
            }
        }
    }
}
