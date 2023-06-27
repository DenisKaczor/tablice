using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			const int Size = 10;
			int kolumna = 0;
			int number = 1;
			int[,] array = new int[Size, Size];
			for (int i = 0; i < Size; i++)
			{
				for(int j = 0; j<Size; j++)
				{
					array[i, j] = number;
					number++;
					Console.Write(" "+array[i, j]+" ");
				}
				Console.WriteLine();
			}
			Console.ReadKey();
		}
	}
}
