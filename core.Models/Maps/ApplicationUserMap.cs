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
            //builder.HasBaseType<IdentityUser>();
            builder.ToTable(name: "AspNetUser", schema: "Security");

            #region Identity

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.AccessFailedCount).HasColumnName("AccessFailedCount");
            builder.Property(c => c.ConcurrencyStamp).HasColumnName("ConcurrencyStamp");
            builder.Property(c => c.Email).HasColumnName("Email");
            builder.Property(c => c.EmailConfirmed).HasColumnName("EmailConfirmed");
            builder.Property(c => c.LockoutEnabled).HasColumnName("LockoutEnabled");
            builder.Property(c => c.LockoutEnd).HasColumnName("LockoutEnd");
            builder.Property(c => c.NormalizedEmail).HasColumnName("NormalizedEmail");
            builder.Property(c => c.NormalizedUserName).HasColumnName("NormalizedUserName");
            builder.Property(c => c.PasswordHash).HasColumnName("PasswordHash");
            builder.Property(c => c.PhoneNumber).HasColumnName("PhoneNumber");
            builder.Property(c => c.PhoneNumberConfirmed).HasColumnName("PhoneNumberConfirmed");
            builder.Property(c => c.SecurityStamp).HasColumnName("SecurityStamp");
            builder.Property(c => c.TwoFactorEnabled).HasColumnName("TwoFactorEnabled");
            builder.Property(c => c.UserName).HasColumnName("UserName");
            
            #endregion


            #region ApplicationUser 

            builder.Property(c => c.Name).HasColumnName("Name");
            builder.Property(c => c.MiddleName).HasColumnName("MiddleName").HasMaxLength(200);
            builder.Property(c => c.LastName).HasColumnName("LastName").HasMaxLength(200);
            builder.Property(c => c.Birthday).HasColumnName("Birthday").HasMaxLength(200);
            
            #endregion
            
        }


    }
}