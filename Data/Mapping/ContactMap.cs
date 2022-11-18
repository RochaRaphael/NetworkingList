using Microsoft.EntityFrameworkCore;
using NetworkingList.Models;

namespace NetworkingList.Data.Mappings
{
    public class ContactMap : IEntityTypeConfiguration<Contact>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");

            //Primary Key
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Name)
                .IsRequired()
                .HasColumnName("Name")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(80);

            builder.Property(x => x.Email)
                .HasColumnName("Email")
                .HasColumnType("NVARCHAR")
                .HasMaxLength(200);

            builder.Property(x => x.Cellphone)
                .HasColumnName("Cellphone")
                .HasColumnType("VARCHAR")
                .HasMaxLength(14);

            builder.Property(x => x.Age)
                .HasColumnName("Age")
                .HasColumnType("INTEGER")
                .HasMaxLength(2);

            builder
                .HasMany(x => x.Skills)
                .WithMany(x => x.Contacts)
                .UsingEntity<Dictionary<string, object>>
                (
                    "ContactSkills",
                    contact => contact
                        .HasOne<Skill>()
                        .WithMany()
                        .HasForeignKey("SkillId")
                        .HasConstraintName("FK_ContractSkills_SkillId"),
                    skill => skill
                        .HasOne<Contact>()
                        .WithMany()
                        .HasForeignKey("ContactId")
                        .HasConstraintName("FK_ContractSkills_ContactId")

                );

        }
    }
}