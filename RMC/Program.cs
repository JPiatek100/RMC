//źródła:
//https://en.wikipedia.org/wiki/Coefficient
//https://github.com/ever-balance/wilks-calculator
//

namespace RMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool close = false;
            while (!close)
            {
                Console.Clear();
                Console.WriteLine("Kalkulator 1 rep max v0.1 \n");
                int mode = GetData.GetVar("Wybierz tryb: ", "[0] Zakończ program\n[1] Bench press\n", 0, 1);

                switch (mode)
                {
                    case 0:
                        Console.Clear();
                        close = true;
                        break;
                    case 1:
                        Console.Clear();
                        Modes.BenchPress();
                        break;
                    default: 
                        Console.Clear();
                        Modes.Info();
                        break;

                }
            }










        }
    }
}