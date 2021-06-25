using System;

namespace GridGenerator
{
    class Program
    {
		//length of row/columns
		static int N =4;

		public static void Main()
		{
			//Constructor for random numbers
			Random random = new Random();

			//intialize 4x4 grid
			int[,] values = new int[4, 4];

			Console.WriteLine("Original Grid");
			for (int i = 0; i < values.GetLength(0); i++)
			{
				for (int k = 0; k < values.GetLength(1); k++)
				{
					values[i, k] = random.Next(1, 10);
					Console.Write(values[i, k] + " ");
				}
				Console.WriteLine();
			}

			//Display 90 degrees grid
			Console.WriteLine("\n");
			Console.WriteLine("Rotated 90 Degrees Right");
			rotate90(values);

			//Display 180 degrees grid
			Console.WriteLine("\n");
			Console.WriteLine("Rotated 180 Degrees Right");
			rotate180(values);

			//Display 270 degrees grid
			Console.WriteLine("\n");
			Console.WriteLine("Rotated 270 Degrees Right");
			rotate270(values);
		}

		//Method to rotate grid 90 degrees
		static void rotate90(int[,] arr)
		{
			for (int j = 0; j < N; j++)
			{
				for (int i = N - 1; i >= 0; i--)
					Console.Write(arr[i, j] + " ");
					Console.WriteLine();
			}
		}
		
		//Method to print grid 180 degrees
		static void rotate180(int[,] arr)
		{
			for (int i = N - 1; i >= 0; i--)
			{
				for (int j = N - 1; j >= 0; j--)
					//print the array of random numbers
					Console.Write(arr[i, j] + " ");
					Console.WriteLine();
			}
		}

		//Method to print grid 270 degrees
		static void rotate270(int[,] arr)
		{
			for (int i = N - 1; i >= 0; i--)
			{
				for (int j = N - 1; j >= 0; j--)
					//print the array of random numbers
					Console.Write(arr[i, j] + " ");
					Console.WriteLine();
			}
		}
	}
}
