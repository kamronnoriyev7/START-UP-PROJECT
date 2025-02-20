using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SportTime.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportTime.DAL.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("users");
            builder.HasKey(builder => builder.UserId);
            builder.Property(u => u.UserId).ValueGeneratedOnAdd();
            builder.Property(u => u.Name).IsRequired().HasMaxLength(30);
            builder.Property(u => u.Number).IsRequired().HasMaxLength(9);
            builder.Property(u => u.Password).IsRequired().HasMaxLength(30);

        }
    }
}
