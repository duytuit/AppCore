using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys003Configuration : IEntityTypeConfiguration<Sys003>
    {
        public void Configure(EntityTypeBuilder<Sys003> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
            entity.HasOne(x => x.Sys002).WithMany(x => x.Sys003).HasForeignKey(x => x.Nhomky_id);
            entity.HasOne(x => x.Sys005).WithMany(x => x.Sys003).HasForeignKey(x => x.Danhmucid);
        }
    }
}
