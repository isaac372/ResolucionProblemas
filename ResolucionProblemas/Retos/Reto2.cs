using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionProblemas.Retos
{
    public class Reto2
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            int DiagonalIzquierda = 0;
            int DiagonalDerecha = 0;

            var Encontrado = arr[0];

            for (int i = 0; i < Encontrado.Count; i++)
            {
                DiagonalIzquierda += arr[i][0 + i];

                DiagonalDerecha += arr[i][Encontrado.Count - i - 1];
            }


            return Math.Abs(DiagonalIzquierda - DiagonalDerecha);
        }

        public static void plusMinus(List<int> arr)
        {
            decimal Zero = 0;
            decimal Negativo = 0;
            decimal Positivo = 0;

            decimal Cantidad = arr.Count;
            for (int i = 0; i < Cantidad; i++)
            {
                if (arr[i] < 0) Negativo++;
                else if (arr[i] > 0) Positivo++;
                else Zero++;

            }

            Console.WriteLine($"{Zero / Cantidad:F6}");
            Console.WriteLine($"{Negativo / Cantidad:F6}");
            Console.WriteLine($"{Positivo / Cantidad:F6}");


            decimal posi = 0;
            decimal neg = 0;
            decimal cero = 0;
            decimal cantidad = arr.Count;
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == 0)
                {
                    cero++;
                }
                if (arr[i] > 0)
                {
                    posi++;
                }
                if (arr[i] < 0)
                {
                    neg++;
                }

            }
            Console.WriteLine(posi / cantidad);
            Console.WriteLine(neg / cantidad);
            Console.WriteLine(cero / cantidad);
        }


        public static void staircase(int n)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                sb.Append(' ',n-(i+1));
                sb.Append('*', i+1);

                Console.WriteLine(sb);
                sb.Clear();
            }

        }

    }
}
