namespace TriVRud;
class Program
{
    public static Field _Field = new Field();
    public static ConsoleKey _Napravlenie;
    static void Main(string[] args)
    {
        do
        {
            _Field.Print();
            HandleInput();
        } while (true);
    }

    private static void HandleInput()
    {
        var key = Console.ReadKey().Key;

        switch (key)
        {
            case ConsoleKey.W:
                if (Field.Cursor.Y - 1 >= 0)
                {
                    Field.Cursor.Y--;
                }
                break;

            case ConsoleKey.S:
                if (Field.Cursor.Y + 1 < Field.Visota_1)
                {
                    Field.Cursor.Y++;
                }
                break;

            case ConsoleKey.A:
                if (Field.Cursor.X - 1 >= 0)
                {
                    Field.Cursor.X--;
                }
                break;

            case ConsoleKey.D:
                if (Field.Cursor.X + 1 < Field.Shirina_2)
                {
                    Field.Cursor.X++;
                }
                break;

            case ConsoleKey.Spacebar:
                Field.SelectOrSwap();
                break;
        }
    }
}

