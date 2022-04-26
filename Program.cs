using System;

namespace CSharp.LabExercise1
{
     class Program
    {
        static void Number1()
        {

            Console.WriteLine("Welcome to the Area and Perimeter Calculator");

            string userChoice = "y";

            while (userChoice == "y" || userChoice == "Y")
            {
                Console.WriteLine("Enter length: ");
                decimal length = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");

                Console.WriteLine("Enter width: ");
                decimal width = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine(" ");

                decimal area = length * width;
                Console.WriteLine("Area: {0} ", area);
                Console.WriteLine(" ");

                decimal perimeter = (2 * length) + (2 * width);
                Console.WriteLine("Perimeter: {0} ", perimeter);
                Console.WriteLine(" ");

                Console.WriteLine("Continue? (y/n): ");
                userChoice = Console.ReadLine();

                if (userChoice == "n" || userChoice == "N")
                {
                    Environment.Exit(1);
                }

            }
                
            
        }

        static void Number2()
        {
            Console.WriteLine("Welcome to Letter Grade Calculator");
            string userChoice = "y"; 

            while (userChoice == "y" || userChoice == "Y")
            {
                Console.WriteLine("Enter numerical grade: ");
                int grade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(" ");

                if (grade < 60)
                {
                    Console.WriteLine("Letter grade: F");
                }
                else if (grade >=60 && grade <= 66)
                {
                    Console.WriteLine("Letter grade: D");
                }
                else if (grade > 66 && grade <= 79)
                {
                    Console.WriteLine("Letter grade: C");
                }
                else if (grade > 79 && grade <= 87)
                {
                    Console.WriteLine("Letter grade: B");
                }
                else if (grade > 87 && grade <= 100)
                {
                    Console.WriteLine("Letter grade: A");
                }
                else
                {
                    Console.WriteLine("Invalid grade");
                }

                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();
                Console.WriteLine(" ");

                if (userChoice == "n" || userChoice == "N")
                {
                    Environment.Exit(1);
                }
            }

            

        }

        static void Number3()
        {
            string userChoice = "y";
            Console.WriteLine("Welcome to the Download Time Estimator");
            Console.WriteLine("This program calculates how long will it take to download a file with a 56k analog modem.");

            while (userChoice == "y" || userChoice == "Y")
            {
                
                Console.WriteLine("Enter a file size (MB): ");
                int fileSize = Convert.ToInt32(Console.ReadLine());

                decimal totalTimeInSeconds = Convert.ToDecimal(fileSize * 1024 / 5.2);
                int seconds = (int)totalTimeInSeconds % 60;
                decimal totalMinutes = totalTimeInSeconds / 60;
                int minutes = (int)totalMinutes % 60;
                int hours = (int)totalMinutes / 60;
                
                Console.WriteLine("A \"56k\" modem will take {0} hours {1} minutes {2} seconds", hours, minutes, seconds);
                Console.WriteLine(" ");
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();

                if (userChoice == "n" || userChoice == "N")
                {
                    Environment.Exit(1);
                }
            }


        }

        static void Number4()
        {
            Console.WriteLine("Enter square size: ");
            int squareSize = Convert.ToInt32(Console.ReadLine());
            int row;
            int column;

                for (column = 0; column < squareSize; column++)
                {
                    for (row = 0; row < squareSize; row++)
                    {
                        Console.Write("*");
                    }
                Console.WriteLine();
                }
        }

        static void Main(string[] args)
        {
            Number1();
            //Number2();
            //Number3();
            //Number4();

        }
    }
}


