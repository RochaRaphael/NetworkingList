using NetworkingList.DataContext;
using NetworkingList.Models;

namespace NetworkingList
{
    public static class DataAccess
    {
        public static void InsertContact()
        {
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();
            Console.Write("Enter the email: ");
            string email = Console.ReadLine();
            Console.Write("Enter the cell phone: ");
            string cellPhone = Console.ReadLine();
            Console.Write("Enter the age: ");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("How many skills do you have?");
            int countSkill = int.Parse(Console.ReadLine());
            Console.WriteLine();


            List<Skill> skills = new List<Skill>();
            string skillName;
            int scoreSkill;
            using (var context = new NatworkingListDataContext())
            {
                for (int i = 1; i <= countSkill; i++)
                {
                    Console.WriteLine($"Enter the skill name number {i}");
                    skillName = Console.ReadLine();

                    var alreadyExists = context.Skills.FirstOrDefault(x => x.SkillName == skillName);
                    if (alreadyExists != null)
                    {
                        skills.Add(alreadyExists);
                    }
                    else
                    {
                        Console.WriteLine("Enter your score from 0 to 10 in this skill");
                        scoreSkill = int.Parse(Console.ReadLine());
                        skills.Add(new Skill { SkillName = skillName, YourSkillScore = scoreSkill });
                    }

                    Console.WriteLine();
                }

                var newContact = new Contact
                {
                    Name = name,
                    Email = email,
                    Cellphone = cellPhone,
                    Age = age,
                    Skills = skills

                };
                context.Contacts.Add(newContact);
                context.SaveChanges();
            }


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