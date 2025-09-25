using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Text;

namespace KetDTombFeladat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // NÉHÁNY VÁLTOZÓ INCIALIZÁLÁSA
            int n = 0;
            int m = 0;
            Random rnd = new Random();


            // BEKÉRÉS
            Console.Write("Adja meg a sorok számát \\-$ ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Adja meg az oszlopok számát \\-$ ");
            m = int.Parse(Console.ReadLine());


            // LISTA LÉTREHOZÁSA A MEGADOTT SZÁMOKBÓL
            int[,] fTomb = new int[n, m];


            // FELTÖLTÉS RANDOM SZÁMOKKAL
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    fTomb[i, j] = rnd.Next(1, 10);
                }
            }


            // KIÍRÁS
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(fTomb[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}