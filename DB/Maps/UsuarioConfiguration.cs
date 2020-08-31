using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MVCProyect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCProyect.DB.Maps
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
           // throw new NotImplementedException();
            builder.ToTable("Usuario");
            builder.HasKey(o=>o.id);

            //builder.Property(o=>o.username).HasColumnName("Username");
        }
    }
}
