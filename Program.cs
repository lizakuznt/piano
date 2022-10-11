namespace Piano
{
    internal class PianoMethods
    {
        static void Main()
        {
            Console.WriteLine("Белые: L, Z, K, U, E, S, V\n" +
                              "Чёрные: I, A, N, T, O\n" +
                              "Переключение между октавами F1 и F2\n" +
                              "Для выхода  нажмите клавишу Escape\n" +
                              "Выберите октаву");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.Clear();

            switch (key.Key)
            {
                case ConsoleKey.F1:
                    oneoctave();
                    break;
                case ConsoleKey.F2:
                    twooctave();
                    break;
            }
        }
        static void oneoctave()
        {
            int[] Octave = new int[]
                { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494};
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.L:
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.Z:
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.A:
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.N:
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.O:
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.V:
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                }
            }
        }

        static void twooctave()
        {
            int[] Octave = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988};
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.L:
                        Console.Beep(Octave[0], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.I:
                        Console.Beep(Octave[1], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.Z:
                        Console.Beep(Octave[2], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.A:
                        Console.Beep(Octave[3], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.K:
                        Console.Beep(Octave[4], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.U:
                        Console.Beep(Octave[5], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.N:
                        Console.Beep(Octave[6], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.E:
                        Console.Beep(Octave[7], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.T:
                        Console.Beep(Octave[8], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.S:
                        Console.Beep(Octave[9], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.O:
                        Console.Beep(Octave[10], 500);
                        Console.Clear();
                        break;
                    case ConsoleKey.V:
                        Console.Beep(Octave[11], 500);
                        Console.Clear();
                        break;
                }
            }
        }  
    }
}