namespace Piano
{
    internal class PianoMethods
    {
        static void Main()
        {
            Console.WriteLine("Белые: L, Z, K, U, E, S, V" + "\n" +
                              "Чёрные: I, A, N, T, O" + "\n" +
                              "Переключение между октавами F1 и F2" + "\n" +
                              "Для выхода  нажмите клавишу Escape" + "\n" + "\n" +
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
                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;

            }
        }
        static void oneoctave()
        {
            int[] Octave = new int[]
                { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 494};
            Start(Octave);
        }

        static void twooctave()
        {
            int[] Octave = new int[]
                { 523, 554, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988};
            Start(Octave);

        }

        static void Start(int[] Octave)
        {
            Console.WriteLine("Для выхода нажмите клавишу Escape");
            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();
                Console.Clear();
                switch (key.Key)
                {
                    case ConsoleKey.L:
                        sound(Octave[0]);
                        break;
                    case ConsoleKey.I:
                        sound(Octave[1]);
                        break;
                    case ConsoleKey.Z:
                        sound(Octave[2]);
                        break;
                    case ConsoleKey.A:
                        sound(Octave[3]);
                        break;
                    case ConsoleKey.K:
                        sound(Octave[4]);
                        break;
                    case ConsoleKey.U:
                        sound(Octave[5]);
                        break;
                    case ConsoleKey.N:
                        sound(Octave[6]);
                        break;
                    case ConsoleKey.E:
                        sound(Octave[7]);
                        break;
                    case ConsoleKey.T:
                        sound(Octave[8]);
                        break;
                    case ConsoleKey.S:
                        sound(Octave[9]);
                        break;
                    case ConsoleKey.O:
                        sound(Octave[10]);
                        break;
                    case ConsoleKey.V:
                        sound(Octave[11]);
                        break;
                    case ConsoleKey.Escape:
                        Environment.Exit(0);
                        break;
                }
            }
        }
        static void sound(int frequency)
        {
            Console.Beep(frequency,500);
            Console.Clear();
        }
    }
}