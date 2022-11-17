using NetworkingList.Models;
using NetworkingList.DataContext;
using Microsoft.EntityFrameworkCore;

namespace NetworkingList
{
    class program
    {
        static void Main(string[] args)
        {

            void Menu()
            {
                Console.WriteLine("CHOSE AN OPTION - PUT A NUMBER");
                Console.WriteLine();
                Console.WriteLine("1- Insert contact");
                Console.WriteLine("2- Delete contact");
                Console.WriteLine("3- Update contact");
                Console.WriteLine("4- Search");
                Console.WriteLine("5- Close the program");
            }


            int option = 1;
            while (option < 5 && option > 0)
            {
                Console.Clear();
                Menu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("BYE, SEE YOU SOON!");
                        break;
                }
            }
        }
    }
}