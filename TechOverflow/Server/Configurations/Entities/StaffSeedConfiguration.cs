using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechOverflow.Shared.Domain;

namespace TechOverflow.Server.Configurations.Entities
{
    public class StaffSeedConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
            builder.HasData(
                new Staff
                {
                    Id = 1,
                    UserName = "HariIzKool",
                    Name = "Harikrishnan Bijoy",
                    ContactNo = 88092644,
                    Password = "Admin",
                    Email = "Harikrishnan.Bijoy04@gmail.com",
                    DoB = new DateTime(2004, 11, 9),
                    Gender = "Male"
                };

        }
    }
}
