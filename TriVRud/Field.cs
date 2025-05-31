using System;
namespace TriVRud
{
	public class Field
	{
		public const int Shirina_2 = 10;
        public const int Visota_1 = 10;
		public static Cell[,] Cells { get; set; }
		public Point Cursor = new Point(0, 0);

        public Field()
		{
			Cells = new Cell[Visota_1, Shirina_2];
			RandomGenerationCells();
		}

        public void Print()
		{
			for(int y = 0; y < Visota_1;y++)
			{
				for (int x = 0; x < Shirina_2; x++)
				{
					bool ISCursor = (y == Cursor.Y && x == Cursor.X);
                    Cells[y, x].Print(ISCursor);
                    Console.Write("  ");
				}
                Console.WriteLine();
                for (int x = 0; x < Shirina_2; x++) {Console.Write(" ");}
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
					CellColors color = (CellColors)random.Next(Enum.GetValues(typeof(CellColors)).Length);

                    Cells[y, x] = new Cell(color);
                }
            }
        }
	}
}

