using AppCore.Data.EF.Extensions;
using AppCore.Data.Entities.System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppCore.Data.EF.Configurations
{
    public class Sys001Configuration: IEntityTypeConfiguration<Sys001>
    {
        public void Configure(EntityTypeBuilder<Sys001> entity)
        {
            entity.HasKey(c => c.Id);
            entity.Property(x => x.Id).ValueGeneratedOnAdd();
        }
    }
}
