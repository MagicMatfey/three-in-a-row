namespace TriVRud;
class Program
{
    public static Field _Field = new Field();
    public static ConsoleKey _Napravlenie;
    static void Main(string[] args)
    {
        do
        {
            _Field.Print(true);
            HandleInput();
        } while (true);
    }

    private static void HandleInput()
    {
        var key = Console.ReadKey().Key;
        Console.Clear();

        switch (key)
        {
            case ConsoleKey.W:
                if (_Field.Cursor.Y -- >= 0)
                {
                    _Field.Cursor.Y--;
                }
                break;

            case ConsoleKey.S:
                if (_Field.Cursor.Y ++ < Field.Visota_1)
                {
                    _Field.Cursor.Y++;
                }
                break;

            case ConsoleKey.A:
                if (_Field.Cursor.X -- >= 0)
                {
                    _Field.Cursor.X--;
                }
                break;

            case ConsoleKey.D:
                if (_Field.Cursor.X ++ < Field.Shirina_2)
                {
                    _Field.Cursor.X++;
                }
                break;
        }
    }
}

