using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primeiro_Projeto_C_Sharp
{

    // private protected internal public

    class Utilidades
    {

        public static (float, float, int) ficha21mar(int[] array, Predicate<int> predi) {


            var filtrados = array.Where(i => predi(i)).ToArray();

            if (filtrados.Length == 0)
                return (0f, 0f, 0);

            int soma = filtrados.Sum();
            float media = (float)soma / filtrados.Length;

            float somaQuadrados = filtrados
                .Select(num => (num - media) * (num - media))
                .Sum();
            float variancia = somaQuadrados / filtrados.Length;
            float desvioPadrao = (float)Math.Sqrt(variancia);

            return (media, desvioPadrao, soma);

        }

        
        
        // Menu
        static internal int menu()
        {
            int op;
            Console.Clear();
            Console.WriteLine("Menu da ficah de trabalho");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("1 - Dobro");
            Console.WriteLine("2 - Selos");
            Console.WriteLine("3 - Paridade");
            Console.Write("Introduza a opção: ");

            if (int.TryParse(Console.ReadLine(), out op))
            {
                return op;
            }
            else
            {
                return -1;

            }
        }
        // Dobro
        static internal int dobro(int n)
        {
            return n * 2;
        }
        //Maquina de selos
        static internal string selos(int EUROS)
        {
            int quoc, resto, s5, s3;
            if (EUROS >= 8)
            {
                quoc = EUROS / 8;
                resto = EUROS % 8;
                switch (resto)
                {
                    case 0: s5 = quoc; s3 = quoc; break;
                    case 1: s5 = quoc - 1; s3 = quoc + 2; break;
                    case 2: s5 = quoc + 1; s3 = quoc - 1; break;
                    case 3: s5 = quoc; s3 = quoc + 1; break;
                    case 4: s5 = quoc - 1; s3 = quoc + 3; break;
                    case 5: s5 = quoc + 1; s3 = quoc; break;
                    case 6: s5 = quoc; s3 = quoc + 2; break;
                    case 7: s5 = quoc + 2; s3 = quoc - 1; break;
                    default: s5 = 0; s3 = 0; break;
                }
            }
            else
            {
                if (EUROS == 3) { s3 = 1; s5 = 0; }
                else if (EUROS == 5) { s3 = 0; s5 = 1; }
                else if (EUROS == 6) { s3 = 2; s5 = 0; }
                else { s5 = 0; s3 = 0; Console.WriteLine("Devolução da Quantia"); }
            }
            return $"Com {EUROS} euros você vai receber: {s5} selos de 5 e {s3} selos de 3";
        }
        // Paridade
        static internal string paridade(int c)
        {
            if (c % 2 == 0)
            {
                return "Par";
            }
            else
            {
                return "Impar";
            }
        }

        static internal void troca(ref int a, ref int b)
        {
            int aux = a;
            a = b;
            b = aux;
        }
        static internal void estatistical(
            out float media,
            out int min,
            out int max,
            ref int negas,
            in int bonus,
            int[] notas)
        {
            negas = 0;
            min = max = notas[0];
            media = (float)min;
            for (int i = 1; i<notas.Length; i++)
            {
                media += (float)notas[i];
                if (max > notas[i]) min = notas[i];
                if (min < notas[i]) max = notas[i];
                if (notas[i] < 10) negas++;


            }
            media /= notas.Length;
            if (bonus > 0) media += bonus;
            {
                
            }
        }

    }
}
