using NetworkingList.Models;
using Microsoft.EntityFrameworkCore;
using NetworkingList.Data.Mappings;

namespace NetworkingList.DataContext
{
    public class NatworkingListDataContext : DbContext
    {
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Skill> Skills { get; set; }

        //Database Connections
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=NetworkingFluentMap;User ID=sa;Password=1q2w3e4r@#$;Trusted_Connection=False; TrustServerCertificate=True;");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ContactMap());
            modelBuilder.ApplyConfiguration(new SkillMap());
        }
    }
}