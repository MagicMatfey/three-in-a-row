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
            _Napravlenie = Console.ReadKey().Key;
            Console.Clear();
            switch(_Napravlenie)
            {
                case ConsoleKey.W:
                    _Field.Cursor.Y -= 1;
                    break;
                case ConsoleKey.S:
                    _Field.Cursor.Y += 1;
                    break;
                case ConsoleKey.D:
                    _Field.Cursor.X += 1;
                    break;
                case ConsoleKey.A:
                    _Field.Cursor.X -= 1;
                    break;
            }
        } while (true);
    }
}

