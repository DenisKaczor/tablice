using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int size = int.Parse(Console.ReadLine());
			while (size <= 0) 
			{
				Console.WriteLine("podaj prawidłowy rozmiar tablicy");
				size = int.Parse(Console.ReadLine());
			}
			int number = 1;
			int[,] array = new int[size, size];
			Console.WriteLine("Tablica{0}x{0}:", size);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					array[i, j] = number;
					number++;
					Console.Write("{0,3} ", array[i, j]);
				}
				Console.WriteLine();
			}

			int[,] tab = new int[size, size]; 

			int wiersz = 0, kolumna = 0, mnoznik = 1; 

			while (mnoznik <= size*size)
			{
				// wypełnianie w prawo
				while (kolumna < size && tab[wiersz, kolumna] == 0)
				{
					tab[wiersz, kolumna] = mnoznik;
					mnoznik++;
					kolumna++;
				}
				kolumna--;
				wiersz++;

				// wypełnianie w dół
				while (wiersz < size && tab[wiersz, kolumna] == 0)
				{
					tab[wiersz, kolumna] = mnoznik;
					mnoznik++;
					wiersz++;
				}
				wiersz--;
				kolumna--;

				// wypełnianie w lewo
				while (kolumna >= 0 && tab[wiersz, kolumna] == 0)
				{
					tab[wiersz, kolumna] = mnoznik;
					mnoznik++;
					kolumna--;
				}
				kolumna++;
				wiersz--;

				// wypełnianie w górę
				while (wiersz >= 0 && tab[wiersz, kolumna] == 0)
				{
					tab[wiersz, kolumna] = mnoznik;
					mnoznik++;
					wiersz--;
				}
				wiersz++;
				kolumna++;
			}

			// wypisanie tablicy na ekranie
			Console.WriteLine("Tablica{0}x{0}:", size);
			for (int i = 0; i < size; i++)
			{
				for (int j = 0; j < size; j++)
				{
					Console.Write("{0,3} ", tab[i, j]);
				}
				Console.WriteLine();
			}


			Console.ReadKey();
		}
	}
	}

