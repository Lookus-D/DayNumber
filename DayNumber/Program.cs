using System;

namespace DayNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me any number, please.");
            //4 = Czwartek;

            Console.WriteLine("Give me number of day:");
            string day = Console.ReadLine();
            int chosenDay = 0;
            Int32.TryParse(day, out chosenDay);

            //which day is assigned to particular number 1-7 {chosenDay}
            if (chosenDay == 1)
            {
                Console.WriteLine($"It is \"Monday\".");
            }
            else if (chosenDay == 2)
            {
                Console.WriteLine($"It is \"Tuesday\".");
            }
            else if (chosenDay == 3)
            {
                Console.WriteLine($"It is \"Wednesday\".");
            }
            else if (chosenDay == 4)
            {
                Console.WriteLine($"It is \"Thursday\".");
            }
            else if (chosenDay == 5)
            {
                Console.WriteLine($"It is \"Friday\".");
            }
            else if (chosenDay == 6)
            {
                Console.WriteLine($"It is \"Saturday\".");
            }
            else //(chosenDay == 7)
            {
                Console.WriteLine($"It is \"Sunday\".");
            }
        }
    }

}
