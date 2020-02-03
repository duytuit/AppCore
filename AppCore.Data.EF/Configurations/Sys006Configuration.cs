using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys006Configuration : IEntityTypeConfiguration<Sys006>
    {
        public void Configure(EntityTypeBuilder<Sys006> entity)
        {
            entity.HasKey(c => c.Id);
            //   entity.Property(x => x.Id).UseIdentityColumn();
            entity.HasOne(x => x.Sys005).WithMany(x => x.Sys006).HasForeignKey(x => x.Danhmucid);
        }
    }
}
