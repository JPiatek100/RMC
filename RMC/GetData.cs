﻿using System.Runtime.InteropServices;

namespace RMC
{



    public class GetData
    {
        public static bool validFormat = false;
        public static string userInput = "12:20";
        public static int hours = 0, minutes = 0;



        static public void GetHour(string zapytanie)
        {

            validFormat = false;
            while (!validFormat)
            {
                Console.WriteLine(zapytanie);
                userInput = Console.ReadLine();

                string[] timeParts = userInput.Split(' ');

                if (timeParts.Length == 2 && int.TryParse(timeParts[0], out hours) && int.TryParse(timeParts[1], out minutes))
                {
                    validFormat = true;
                }
                else
                {
                    Console.WriteLine("Nieprawidłowy format godziny. Spróbuj ponownie.");
                }
            }
            validFormat = false;

        }



        static public bool GetDefault(string zapytanie)
        {
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine(zapytanie);
                switch (Console.ReadLine())
                {
                    case "y":
                        return true;
                        break;
                        valid = true;
                    case "n":
                        return false;
                        valid = true;
                        break;
                    default:
                        valid = false;
                        break;
                }

            }
            return false;

        }


        static public int GetVar(string tytul, string zapytanie, int min, int max)
        {
            validFormat = false;

            while (!validFormat)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(tytul);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(zapytanie);
                string input = Console.ReadLine();

                if (int.TryParse(input, out int value))
                {
                    if (value >= min && value <= max)
                    {
                        validFormat = true;
                        return value;
                        
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj liczbę w przedziale " + min + '-' + max + "\n");
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Podane dane nie są liczbą!\n");
                }
            }
            return 0;

        }
    }

}