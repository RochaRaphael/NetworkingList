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
                Console.WriteLine("2- Update contact");
                Console.WriteLine("3- Delete contact");
                Console.WriteLine("4- Insert skill");
                Console.WriteLine("5- Updae skill");
                Console.WriteLine("6- Delete skill");
                Console.WriteLine("7- Search");
                Console.WriteLine("8- Close the program");
            }

            int option = 1;
            while (option < 7 && option >= 0)
            {
                Console.Clear();
                Menu();
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        DataAccess.InsertContact();
                        break;

                    case 2:
                        DataAccess.UpdateContact();
                        break;

                    case 3:
                        DataAccess.DeleteContact();
                        break;

                    case 4:
                        break;

                    case 5:
                        break;

                    case 6:
                        DataAccess.DeleteSkill();
                        break;

                    case 7:
                        break;

                    case 8:
                        Console.Clear();
                        Console.WriteLine("BYE, SEE YOU SOON!");
                        break;

                    default:
                        Console.WriteLine("Invalid option. enter a number from 1 to 7");
                        option = 0;
                        break;
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
        }
    }
}
