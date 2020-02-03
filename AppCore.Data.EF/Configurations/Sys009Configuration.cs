using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys009Configuration:IEntityTypeConfiguration<Sys009>
    {
        public void Configure(EntityTypeBuilder<Sys009> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
            entity.HasOne(x => x.Sys001).WithMany(x => x.Sys009).HasForeignKey(x => x.UserID);
            entity.HasOne(x => x.Sys002).WithMany(x => x.Sys009).HasForeignKey(x => x.Nhomky_id);
        }
    }
}
