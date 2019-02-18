using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SpaUserControl.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaUserControl.Infraestructure.Data.Map
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.HasIndex(x => x.Email).IsUnique();

            builder.Property(x => x.Name).HasMaxLength(60).IsRequired();
            builder.Property(x => x.Email).HasMaxLength(160).IsRequired();
        }
    }
}
