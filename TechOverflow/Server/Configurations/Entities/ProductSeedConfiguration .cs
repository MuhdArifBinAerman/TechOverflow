using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechOverflow.Shared.Domain;

namespace TechOverflow.Server.Configurations.Entities
{
    public class ProductSeedConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product
                {
                    Id = 1,
                    PName="IPhone -1",
                    PRetailPrice=6969,
                    PBrand="",
                    PDescription="",
                    CatID=""
                },
                new Product
                {
                    Id=2,
                    

                });

        }
    }
}
