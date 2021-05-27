using System;

namespace Simulating_2d_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
			int[] table;
			Console.WriteLine("Declare Table: ");
			Console.WriteLine("");
			table = declareTable(6,4);
			
			Console.WriteLine("");
			Console.WriteLine("Read Table Cell: ");
			
			int read_cell = readTableCell(table, 2,3);
			Console.WriteLine(read_cell);
			
			Console.WriteLine("");
			Console.WriteLine ("Insert a value: ");
			int cell = int.Parse(Console.ReadLine());
			
			Console.WriteLine("");
			Console.WriteLine ("Write Table Cell: ");
			
			int write_cell = writeTableCell (table, 2, 3, cell);
			Console.WriteLine(write_cell);
			Console.WriteLine("");
			
			for (int i = 0; i < 6; i++)
			{
				for (int x = 0; x < 4; x++)
					Console.Write((table[i * 4 + x]) + " ");
					Console.Write("\n");
			}
			
			Console.ReadKey();
            
        }
		
		public static int[] declareTable(int rows, int columns)
		{
			int length = rows*columns;
			int[] table = new int[length];
			
			for (int i = 0; i < rows; i++)
			{
				for (int x = 0; x < columns; x++)
					Console.Write((table[i * columns + x]) + " ");
					Console.Write("\n");
			}
			return table;
		}
		
		public static int readTableCell(int[] table, int row, int column)
		{
			int width = row;
			int find_cell = row * width + column;
			return table [find_cell];
		}
		
		public static int writeTableCell(int[] table, int row, int column, int cell)
		{
			int width = row;
			int find_cell = row * width + column;
			table[find_cell] = cell;
			return table[find_cell];
		}
    }
}
