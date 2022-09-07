

using System;

namespace assignment2ism4300
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you expect to get in ISM4300: ");
            try
            {
                string input = Console.ReadLine();
                decimal grade = decimal.Parse(input);
                if (grade >= 90)
                {

                    Console.WriteLine("Your grade is A");

                }
                else if ((grade <= 89) && (grade >= 80))
                {
                    Console.WriteLine("Your grade is B");

                }
                else if ((grade <= 79) && (grade >= 70))
                {
                    Console.WriteLine("Your grade is C");

                }
                else if ((grade <= 69) && (grade >= 60))
                {
                    Console.WriteLine("Your grade is D");

                }
                else
                {
                    Console.WriteLine("Your grade is F");

                }

            }// end of try
            catch
            {
                Console.WriteLine("Use decimal data type for grade");
                Console.WriteLine("----OR------");
                Console.WriteLine("Use an integer data type grade");
                Console.WriteLine("Press any key to exit");
                Console.ReadKey();
            }// end of catch
        }
    }
}


