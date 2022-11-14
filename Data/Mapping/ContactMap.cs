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
                .HasColumnType("BIGINT")
                .HasMaxLength(14);

            builder.Property(x => x.Age)
                .HasColumnName("Age")
                .HasColumnType("INTEGER")
                .HasMaxLength(2);
        }
    }
}