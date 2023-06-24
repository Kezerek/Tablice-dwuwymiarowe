using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3_dla_zad_1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int rozmiar;
            bool poprawnyRozmiar = false;

            do
            {
                Console.WriteLine("Podaj rozmiar tablicy (liczba wierszy i kolumn): ");
                string tekst = Console.ReadLine();

                if (int.TryParse(tekst, out rozmiar) && rozmiar > 0)
                {
                    poprawnyRozmiar = true;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy rozmiar. Podaj liczbę naturalną większą od zera.");
                }
            } while (poprawnyRozmiar == false);

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
                        tablica[obecnyWiersz, obecnaKolumna] = poczatkowaLiczba;
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
