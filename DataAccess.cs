using NetworkingList.DataContext;
using NetworkingList.Models;

namespace NetworkingList
{
    public static class DataAccess
    {
        public static void InsertContact()
        {


        }

        public static void UpdateContact()
        {

            using (var context = new NatworkingListDataContext())
            {
                Console.WriteLine("Enter the name of the contact you want to update");
                string name = Console.ReadLine();

                var contact = context.Contacts.FirstOrDefault(x => x.Name == name);
                if (contact != null)
                {
                    Console.WriteLine("Choose an option you want to update");
                    Console.WriteLine();
                    Console.WriteLine($"1- Name:{contact.Name}");
                    Console.WriteLine($"2- Email:{contact.Email}");
                    Console.WriteLine($"3- Cell phone:{contact.Cellphone}");
                    Console.WriteLine($"4- Age:{contact.Age}");

                    int option = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the new upgrade");
                    var update = Console.ReadLine();

                    switch (option)
                    {
                        case 1:
                            contact.Name = update;
                            break;

                        case 2:
                            contact.Email = update;
                            break;

                        case 3:
                            contact.Cellphone = update;
                            break;

                        case 4:
                            contact.Age = int.Parse(update);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Name not found");
                }

                context.Update(contact);
                context.SaveChanges();


            }
        }

        public static void DeleteContact()
        {

        }
    }
}