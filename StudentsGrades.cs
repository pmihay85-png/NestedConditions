using System;

namespace Students_Grade
{
    internal class Students_Grade
    {
        static void Main()
        {
            Console.Write("Enter grade: ");

            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Invalid input!");
                return;
            }

            if (grade >= 90)
            {
                Console.WriteLine("A");
            }
            else
            {
                if (grade >= 80)
                {
                    Console.WriteLine("B");
                }
                else
                {
                    if (grade >= 70)
                    {
                        Console.WriteLine("C");
                    }
                    else
                    {
                        if (grade >= 60)
                        {
                            Console.WriteLine("D");
                        }
                        else
                        {
                            Console.WriteLine("F");
                        }
                    }
                }
            }

            Console.WriteLine("That is your grade!");
        }
    }
}
