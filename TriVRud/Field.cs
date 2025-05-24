using System;
namespace TriVRud
{
	public class Field
	{
		public const int Shirina_2 = 10;
        public const int Visota_1 = 10;
		public static Cell[,] Cells;
		public Point Cursor = new Point(1,1);

        public Field()
		{
			Cells = new Cell[Visota_1, Shirina_2];
			RandomGenerationCells();
		}

		public void Print(bool bol)
		{
			for(int y = 0; y < Visota_1;y++)
			{
				for (int x = 0; x < Shirina_2; x++)
				{
					if(bol == true && y == Cursor.Y && x == Cursor.X)
					{
                        Console.ForegroundColor = ConsoleColor.Black;
                        Cells[Cursor.Y,Cursor.X].Print(true);
                        Console.Write(" ");
                    }
					else
					{
                        Cells[y, x].Print(false);
                        Console.Write(" ");
                    }
				}
                Console.WriteLine();
            }
		}

		private void RandomGenerationCells()
		{
			Random random = new Random();

            for (int y = 0; y < Visota_1; y++)
            {
                for (int x = 0; x < Shirina_2; x++)
                {
					Cells[y, x] = new Cell((CellColors)random.Next(Enum.GetValues(typeof(CellColors)).Length));
                }
            }
        }
	}
}

