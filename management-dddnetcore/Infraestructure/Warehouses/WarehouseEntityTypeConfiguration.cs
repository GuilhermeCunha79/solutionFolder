﻿using DDDNetCore.Domain.Warehouses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DDDSample1.Domain.Warehouses;

namespace DDDSample1.Infrastructure.Warehouses
{
    internal class WarehouseEntityTypeConfiguration : IEntityTypeConfiguration<Warehouse>
    {
        public void Configure(EntityTypeBuilder<Warehouse> builder)
        {
            //builder.ToTable("Warehouses", SchemaNames.DDDSample1);
            builder.HasKey(b => b.Id);
            builder.OwnsOne(b => b.WarehouseIdentifier);
            builder.OwnsOne(b => b.WarehouseDesignation);
            builder.OwnsOne(b => b.WarehouseAddress);
            builder.OwnsOne(b => b.WarehouseCoordinates);
            builder.OwnsOne(b => b.Altitude);
            //builder.Property<bool>("_active").HasColumnName("Active");
        }
    }
}