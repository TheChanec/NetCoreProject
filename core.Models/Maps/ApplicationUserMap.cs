using core.Models.Entities;
using Core.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Maps
{
    internal class ApplicationUserMap : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            builder.HasBaseType<IdentityUser>();
            builder.ToTable("Person");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(c => c.Name).HasColumnName("Name").HasMaxLength(200);
            builder.Property(c => c.MiddleName).HasColumnName("MiddleName").HasMaxLength(200);
            builder.Property(c => c.LastName).HasColumnName("LastName").HasMaxLength(200);
            builder.Property(c => c.Birthday).HasColumnName("Birthday").HasMaxLength(200);
            builder.Property(c => c.IdApplicationUser).HasColumnName("IdApplicationUser").HasMaxLength(200);

            
        }


    }
}