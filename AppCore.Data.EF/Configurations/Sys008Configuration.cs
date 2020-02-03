using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys008Configuration : IEntityTypeConfiguration<Sys008>
    {
        public void Configure(EntityTypeBuilder<Sys008> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
            entity.HasOne(x => x.Sys006).WithMany(x => x.Sys008).HasForeignKey(x => x.Menuid);
            entity.HasOne(x => x.Sys002).WithMany(x => x.Sys008).HasForeignKey(x => x.Nhomky_id);
        }
    }
}
