using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tablice_dwuwymiarowe
{
    internal class zad1
    {
        static void Main(string[] args)
        {
            const int rozmiar = 10;
            int[,] tablica = new int[rozmiar, rozmiar];
            int poczatkowaLiczba = 1;

            for (int obecnyWiersz = 0; obecnyWiersz < rozmiar; obecnyWiersz++)
            {
                if (obecnyWiersz % 2 == 0)
                {
                    for (int obecnaKolumna = 0; obecnaKolumna < rozmiar; obecnaKolumna++)
                    {
                        tablica[obecnyWiersz, obecnaKolumna] = poczatkowaLiczba;
                        poczatkowaLiczba++;
                    }
                }
                else
                {
                    for (int obecnaKolumna = rozmiar - 1; obecnaKolumna >= 0; obecnaKolumna--)
                    {
                        tablica[obecnyWiersz,obecnaKolumna] = poczatkowaLiczba;
                        poczatkowaLiczba++;
                    }
                }
            }

            for (int i = 0; i < rozmiar; i++)
            {
                for (int j = 0; j < rozmiar; j++)
                {
                    Console.Write(tablica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
