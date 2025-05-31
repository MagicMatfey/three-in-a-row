using System;
namespace TriVRud
{
	public class Field
	{
		public const int Shirina_2 = 10;
        public const int Visota_1 = 10;
		public Cell[,] Cells { get; set; }
		public Point Cursor = new Point(0, 0);
        public Point SelectedCursor;

        public Field()
		{
			Cells = new Cell[Visota_1, Shirina_2];
			RandomGenerationCells();
		}

        public void Print()
		{
            Console.Clear();
            for (int y = 0; y < Visota_1;y++)
			{
				for (int x = 0; x < Shirina_2; x++)
				{
                    bool IsCursor = (y == Cursor.Y && x == Cursor.X);
                    bool IsSelected = (SelectedCursor != null && SelectedCursor.X == x&& SelectedCursor.Y == y);
                    Cells[y, x].Print(IsCursor, IsSelected);
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

		public void SelectOrSwap()
        {
            if(SelectedCursor == null)
            {
                SelectedCursor = new Point(Cursor.Y, Cursor.X);
            }
            else
            {
                int y = Math.Abs(Cursor.Y - SelectedCursor.Y);
                int x = Math.Abs(Cursor.X - SelectedCursor.X);

                if ((x == 1 && y == 0) || (x == 0 && y == 1))
                {
                    SwapCells(Cursor,SelectedCursor);
                    SelectedCursor = null;
                    Print();
                }
            }
        }

        private void SwapCells(Point cursor, Point selected)
        {
            Cell temp = Cells[cursor.Y, cursor.X];
            Cells[cursor.Y, cursor.X] = Cells[selected.Y, selected.X];
            Cells[selected.Y, selected.X] = temp;
        }
    }
}

