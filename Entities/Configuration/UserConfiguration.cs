using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new User
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    UserName = "jlangenderfer",
                    Password = "password1",
                    Email = "jl822@njit.edu",
                    Status = "Student",
                    SystemRoleID = "54321", 
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                    OrganizationId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
                },
                new User
                {
                    Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
                    UserName = "jl822",
                    Password = "password2",
                    Email = "jl823@njit.edu",
                    Status = "Student",
                    SystemRoleID = "65432",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                    OrganizationId = new Guid("4B78165E-813C-418C-A29E-3046D7C726B5")
                },
                 new User
                 {
                     Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
                     UserName = "jderfer31",
                     Password = "password3",
                     Email = "jl824@njit.edu",
                     Status = "Student",
                     SystemRoleID = "76543",
                     CreatedDate = "06-24-2020",
                     UpdatedDate = "06-24-2020",
                     OrganizationId = new Guid("D2E6AD7B-FDF6-48B3-8801-B9F22883C9D5")
                 }
            );
        }
    }
}