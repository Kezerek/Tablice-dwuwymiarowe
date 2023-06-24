using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zad_3_dla_zad_2
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
            int obecnyWiersz = 0;
            int obecnaKolumna = 0;
            int kierunek = 0; // 0 - prawo; 1 - doł; 2 - lewo, 3 - góra

            for (int obecnaliczba = 1; obecnaliczba <= rozmiar * rozmiar; obecnaliczba++)
            {
                tablica[obecnyWiersz, obecnaKolumna] = obecnaliczba;
                switch (kierunek)
                {
                    case 0: //prawo
                        if (obecnaKolumna + 1 >= rozmiar || tablica[obecnyWiersz, obecnaKolumna + 1] != 0)
                        {
                            kierunek = 1;
                            obecnyWiersz++;
                        }
                        else
                        {
                            obecnaKolumna++;
                        }
                        break;
                    case 1: // dół
                        if (obecnyWiersz + 1 >= rozmiar || tablica[obecnyWiersz + 1, obecnaKolumna] != 0)
                        {
                            kierunek = 2;
                            obecnaKolumna--;
                        }
                        else
                        {
                            obecnyWiersz++;
                        }
                        break;
                    case 2: // lewo
                        if (obecnaKolumna - 1 < 0 || tablica[obecnyWiersz, obecnaKolumna - 1] != 0)
                        {
                            kierunek = 3;
                            obecnyWiersz--;
                        }
                        else
                        {
                            obecnaKolumna--;
                        }
                        break;
                    case 3: // góra
                        if (tablica[obecnyWiersz - 1, obecnaKolumna] != 0)
                        {
                            kierunek = 0;
                            obecnaKolumna++;
                        }
                        else
                        {
                            obecnyWiersz--;
                        }
                        break;
                    default:
                        break;
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
