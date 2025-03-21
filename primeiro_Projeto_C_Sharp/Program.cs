using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_Projeto_C_Sharp
{
    internal class Program
    {
        private static Predicate<int> predi;

        static void Main(string[] args)

        {

            int[] array = { 25, 67, 10, 5, 98, 37 };
            Predicate<int> predi = x => x > 4;

            var (media, desvioPadrao, soma) = Utilidades.ficha21mar(array, predi);
            

            Console.WriteLine($"Média: {media}");
            Console.WriteLine($"Desvio Padrão: {desvioPadrao}");
            Console.WriteLine($"Soma: {soma}");

            //float med;
            //int minimo, maximo, negativos = 0, bonus = 0;
            //int[] notas = { 11, 12, 13 };
            //Utilidades.estatistical(
            //    out med,
            //    out minimo,
            //    out maximo,
            //    ref negativos,
            //    in bonus,
            //    notas);

            //Console.WriteLine($"Média: {med}");
            //Console.WriteLine($"Mínimo: {minimo}");
            //Console.WriteLine($"Máximo: {maximo}");
            //Console.WriteLine($"Negativos: {negativos}");
            //Console.WriteLine($"Bonus: {bonus}");
            //Console.WriteLine($"Notas: {string.Join(" : ", notas)}");


        }
        /*{
            int opcao, num;

            for (; ; )
            { //ciclo infinito for (;;)

                opcao = Utilidades.menu();
                if (opcao == 0) break;// Se for 0 sai do ciclo
                try//Valida se é um número
                {
                    switch (opcao)//Valida a opção
                    {
                        case 1://faz o dobro
                            Console.WriteLine("Execicío 1: Dobro");
                            Console.Write("Escolha um número: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"O dobro de {num} = {Utilidades.dobro(num)}");
                            break;

                        case 2://faz a máquina de selos
                            Console.WriteLine("Execicío 2: Selos");
                            Console.Write("Escolha um número: ");
                            num = int.Parse(Console.ReadLine());
                            Console.WriteLine($"{Utilidades.selos(num)}");
                            break;

                        case 3://faz a paridade
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
        */
    }
}
