using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys004Configuration : IEntityTypeConfiguration<Sys004>
    {
        public void Configure(EntityTypeBuilder<Sys004> entity)
        {
            entity.HasKey(c => c.Id);
         //   entity.Property(x => x.Id).UseIdentityColumn();
           
        }
    }
}
