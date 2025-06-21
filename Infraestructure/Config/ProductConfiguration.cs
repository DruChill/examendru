using System;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructure.Config;

public class ProductConfiguration : IEntityTypeConfiguration<Producto>
{
    public void Configure(EntityTypeBuilder<Producto> builder)
    {
        builder.Property(x => x.Precio).HasColumnType("decimal(18,2)");
        builder.Property(x => x.Nombre).IsRequired();
    }
}
