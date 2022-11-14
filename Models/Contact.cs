namespace NetworkingList.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int Age { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Cellphone { get; set; }
        public IList<Skill> Skills { get; set; }

    }
}