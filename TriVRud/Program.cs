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
                if (_Field.Cursor.Y > 0)
                {
                    _Field.Cursor.Y--;
                }
                break;

            case ConsoleKey.S:
                if (_Field.Cursor.Y + 1 < Field.Visota_1)
                {
                    _Field.Cursor.Y++;
                }
                break;

            case ConsoleKey.A:
                if (_Field.Cursor.X > 0)
                {
                    _Field.Cursor.X--;
                }
                break;

            case ConsoleKey.D:
                if (_Field.Cursor.X + 1 < Field.Shirina_2)
                {
                    _Field.Cursor.X++;
                }
                break;

            case ConsoleKey.Spacebar:
                _Field.SelectOrSwap();
                break;
        }
    }
}

