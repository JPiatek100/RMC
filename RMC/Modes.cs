namespace RMC
{
    internal class Modes
    {

        static public void Info() // 0
        {
            Console.WriteLine("Jakub Piątek 2023");
            Console.ReadLine();
        }


        static public string BenchPress() // 1
        {

            int reps = GetData.GetVar("Podaj liczbę powtórzeń: ", "", 1, 200);
            Console.Clear();
            double ciezar = GetData.GetVar("Podaj ciężar [kg]: ", "", 1, 600);
            Console.Clear();

            double rM = Math.Round(ciezar * reps * 0.0252 + ciezar,1);
            double proc = Math.Round((ciezar / rM) * 100, 1);

            Console.Write("Jeżeli zrobiłeś " + reps + 'x' + ciezar + "kg, to twój 1 rep max to: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(+rM + "kg");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Teraz zrobiłeś " + proc + "% swojego maxa\n");

            Console.WriteLine("Naciśnij Enter aby wejść do menu");
            return Console.ReadLine();

        }









    }
}
