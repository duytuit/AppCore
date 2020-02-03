using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys007Configuration : IEntityTypeConfiguration<Sys007>
    {
        public void Configure(EntityTypeBuilder<Sys007> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
            entity.HasOne(x => x.Sys004).WithMany(x => x.Sys007).HasForeignKey(x => x.Groupid);
        }
    }
}
