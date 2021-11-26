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
            //decimal Zero = 0;
            //decimal Negativo = 0;
            //decimal Positivo = 0;

            //decimal Cantidad = arr.Count;
            //for (int i = 0; i < Cantidad; i++)
            //{
            //    if (arr[i] < 0) Negativo++;
            //    else if (arr[i] > 0) Positivo++;
            //    else Zero++;

            //}

            //Console.WriteLine($"{Zero / Cantidad:F6}");
            //Console.WriteLine($"{Negativo / Cantidad:F6}");
            //Console.WriteLine($"{Positivo / Cantidad:F6}");


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
                sb.Append(' ', n - (i + 1));
                sb.Append('*', i + 1);

                Console.WriteLine(sb);
                sb.Clear();
            }

        }

        public static void miniMaxSum(List<int> arr)
        {
            long SumaMinimo = 0;
            long SumaMaximo = 0;
            var orderdenar = arr.OrderBy(e => e).ToList();

            for (int i = 0; i < orderdenar.Count; i++)
            {
                if (i >= 0 && i < orderdenar.Count - 1)
                {
                    SumaMinimo += orderdenar[i];
                }

                if (i > 0 && i <= orderdenar.Count)
                {
                    SumaMaximo += orderdenar[i];
                }
            }

            Console.WriteLine(SumaMinimo + " " + SumaMaximo);

        }

        //You are in charge of the cake for a child's birthday.
        //You have decided the cake will have one candle for each year
        //of their total age. They will only be able to blow out the tallest
        //of the candles. Count how many candles are tallest.
        public static int birthdayCakeCandles(List<int> candles)
        {
            int totalExistentes = 0;
            int max = candles.Max();

            for (int i = 0; i < candles.Count; i++)
            {
                if (candles[i] == max) totalExistentes++;
            }
            return totalExistentes;
        }

        //  Given a time in -hour AM/PM format, convert it to military(24-hour) time.
        //Note: - 12:00:00AM on a 12-hour clock is 00:00:00 on a 24-hour clock.
        //- 12:00:00PM on a 12-hour clock is 12:00:00 on a 24-hour clock.
        public static string timeConversion(string s)
        {
           string Hour=  DateTime.Parse(s).ToString();
            return DateTime.Parse(s).ToLongTimeString();
        }


    }
}
