using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NetworkingList.Models;

namespace NetworkingList.Data.Mappings
{
    public class SkillMap : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder.ToTable("Skill");

            //Primary key
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .ValueGeneratedOnAdd()
            .UseIdentityColumn();

            builder.Property(x => x.SkillName)
            .IsRequired() //Not null
            .HasColumnName("SkillName")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);

            builder.Property(x => x.YourSkillScore)
            .IsRequired() //Not null
            .HasColumnName("YourSkillScore")
            .HasColumnType("NVARCHAR")
            .HasMaxLength(80);
        }
    }
}