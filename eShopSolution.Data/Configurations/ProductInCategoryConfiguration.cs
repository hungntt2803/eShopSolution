using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace eShopSolution.Data.Configurations
{
    public class ProductInCategoryConfiguration : IEntityTypeConfiguration<ProductInCategory>
    {
        public void Configure(EntityTypeBuilder<ProductInCategory> builder)
        {
            builder.HasKey(x => new { x.ProductId,x.CategoryId});
            builder.ToTable("ProductInCategory");
            builder.HasOne(pic => pic.Product).WithMany(pc => pc.ProductInCategory).HasForeignKey(pc => pc.ProductId);
            builder.HasOne(pic => pic.Category).WithMany(pc => pc.ProductInCategory).HasForeignKey(pc => pc.CategoryId);
        }
    }
}
