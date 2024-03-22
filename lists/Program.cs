using System.ComponentModel.Design;
using System.Globalization;
using System.Reflection.Emit;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace lists
{
    internal class Program
    {
        public static void menu()
        {
            List<int> numbers = new List<int>();
            Random generator = new Random();
            string choice;
            int addValue, valueOcc;

            Console.WriteLine("Here is a list of 25 random numbers from 10 - 20:");
            Console.WriteLine();

            for (int i = 0; i <= 25; i++)
            {
                numbers.Add(generator.Next(10, 21));

                Console.Write(numbers[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Please enter the number corresponding to the option you wish to choose.");
            Console.WriteLine("\n\r1 – Sort the list (highest to lowest)\r\n2 – Make a new list of random numbers\r\n3 – Remove a number (by value)\r\n4 – Add a value to the list\r\n5 – Count the number of occurrences of a specified number\r\n6 – Print the largest value\r\n7 – Print the smallest value\r\n8 – Quit");
            Console.WriteLine();

            int option = 0;

            option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.Clear();

                numbers.Sort();

                Console.WriteLine("Sorted numbers:");

                foreach (int num in numbers)
                {
                    Console.Write(num + " ");
                }

                Console.WriteLine();
                Console.WriteLine("If you wish to run the program again, enter Y, if not enter N:");

                Console.WriteLine();
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to close.");
                }

            }
            else if (option == 2)
            {
                Console.Clear();
                menu();
            }
            else if (option == 3)
            {
                Console.Clear();
                Console.WriteLine("Please enter the value you wish to remove from the list:");
                Console.WriteLine();

                int value;

                value = Convert.ToInt32(Console.ReadLine());

                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    if (numbers[i] == value)
                    {
                        numbers.RemoveAt(i);
                    }
                }

                Console.WriteLine();
                Console.WriteLine("Here is the modified list:");
                Console.WriteLine();

                foreach (int num in numbers)
                {

                    Console.Write(num + " ");
                }

                Console.WriteLine();
                Console.WriteLine("If you wish to run the program again, enter Y, if not enter N:" ) ;

                Console.WriteLine();
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to close.");
                }

            }
            else if (option == 4)
            {
                Console.Clear();
                Console.WriteLine("Enter the value that you want to add to the list:");
                Console.WriteLine();

                addValue = Convert.ToInt32(Console.ReadLine());

                numbers.Add(addValue);
                Console.WriteLine();
                Console.WriteLine("New list:") ;
                Console.WriteLine();
                Console.WriteLine();

                for (int i = 0; i <= 26; i++)
                {
                    Console.Write(numbers[i] + " ") ;
                }
                
                Console.WriteLine();
                Console.WriteLine("If you wish to run the program again, enter Y, if not enter N:");

                Console.WriteLine();
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to close.");
                }

            }
            else if (option == 5)
            {
                Console.Clear() ;
                int x = 0;

                Console.WriteLine("Enter the value to count occurances:");
                Console.WriteLine();

                valueOcc = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                for (int i = 0; i <= 25; i++)
                {

                    if (numbers[i] == valueOcc)
                    {
                        x = x + 1;
                    }
                }

                Console.WriteLine("The value " + valueOcc + " occured " + x + " time.") ;
            }
            else if (option == 6)
            {
                Console.Clear();
                numbers.Sort();
                Console.WriteLine("The largest number in the list is:");
                Console.WriteLine();
                Console.WriteLine(numbers[25]) ;
                Console.WriteLine() ;
                Console.WriteLine("If you wish to run the program again, enter Y, if not enter N:");

                Console.WriteLine();
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to close.");
                }
            }
            else if (option == 7)
            {
                Console.Clear();
                numbers.Sort();
                Console.WriteLine("The smallest number in the list is:");
                Console.WriteLine();
                Console.WriteLine(numbers[1]);
                Console.WriteLine();
                Console.WriteLine("If you wish to run the program again, enter Y, if not enter N:");

                Console.WriteLine();
                choice = Console.ReadLine().ToUpper();

                if (choice == "Y")
                {
                    Console.Clear();
                    menu();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to close.");
                }
            }
            else if (option == 8)
            {
                Console.Clear();
                Console.WriteLine("Press 'enter' to quit the program.");
            }
            else
            {
                Console.Clear();
                menu();
            }
        }

        static void Main(string[] args)
        {
            menu();
        }
    }
}