using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResolucionProblemas.Retos
{
    public class Reto1
    {
        /// <summary>
        /// Problema 1
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static int simpleArraySum(List<int> ar)
        {
            int suma = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                suma += ar[i];
            }

            return suma;
        }
        /// <summary>
        /// Problema 2
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        /// 

        //List<int> a = new List<int>();
        //a.Add(5);
        //    a.Add(6);
        //    a.Add(7);

        //    List<int> b = new List<int>();
        //b.Add(3);
        //    b.Add(6);
        //    b.Add(10);
        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            List<int> retornar = new List<int>();
            int iteradorA = 0;
            int iteradorB = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    iteradorA += 1;
                }

                if (b[i] > a[i])
                {
                    iteradorB += 1;
                }
            }
            retornar.Add(iteradorA);
            retornar.Add(iteradorB);
            return retornar;
        }
        /// <summary>
        /// 3 ser problema 
        /// </summary>
        /// <param name="ar"></param>
        /// <returns></returns>
        public static long aVeryBigSum(List<long> ar)
        {
            long retornar = 0;
            for (int i = 0; i < ar.Count; i++)
            {
                retornar += ar[i];
            }
            return retornar;
        }

    }
}
