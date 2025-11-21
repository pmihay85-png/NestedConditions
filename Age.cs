using System;

namespace NestedConditions
{
    internal class Age
    {
        public static bool person { get; private set; }

        static void Main()
        {
            Console.WriteLine("Enter your age: ");
            person = true;

            int age = int.Parse(Console.ReadLine());

            if (person)
            {
                switch (age)
                {
                    case <= 12:
                        Console.WriteLine("You are a child.");
                        break;

                    case > 12 and < 18:
                        Console.WriteLine("You are a teenager.");
                        break;

                    case >= 18:
                        Console.WriteLine("You are an adult.");
                        break;

                  
                }
            }
        }
    }
}
