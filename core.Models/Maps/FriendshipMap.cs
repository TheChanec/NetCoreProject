using Core.Models.Entities.Relations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models.Maps
{
    internal class FriendshipMap  : IEntityTypeConfiguration<Friendship>
    {
        public void Configure(EntityTypeBuilder<Friendship> builder)
        {
            //builder.HasBaseType<IdentityUser>();
            builder.ToTable(name: "FriendShip", schema: "Security");

            #region Identity

            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).HasColumnName("Id");
            builder.Property(c => c.IdReceiving).HasColumnName("IdReceiving");
            builder.Property(c => c.IdRequesting).HasColumnName("IdRequesting");
            builder.Property(c => c.Active).HasColumnName("Active");
            builder.Property(c => c.Date).HasColumnName("Date");

            #endregion


            #region ApplicationUser 

            builder.HasOne(x => x.Receiving).WithMany(r => r.FriendsReceiving).HasForeignKey(x=> x.IdReceiving);
            builder.HasOne(x => x.Requesting).WithMany(r => r.FriendsRequesting).HasForeignKey(x => x.IdRequesting);


            #endregion

        }


    }
}