namespace NetworkingList.Models
{
    public class Skill
    {
        public int Id { get; set; }
        public string SkillName { get; set; }
        public IList<Contact> Contacts { get; set; }
    }
}