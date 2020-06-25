using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseAssignmentManagemnetConfiguration : IEntityTypeConfiguration<User>
    {
        
        private Guid Id;
        private string AssignmentTitle;
        private string Description;
        private string CourseID;

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new CourseAssignmentManagemnetConfiguration
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    AssignmentTitle = "Web API",
                    Description = "Project 1",
                    CourseID = "IS690850"

                },
                new CourseAssignmentManagemnetConfiguration
                {
                    Id = new Guid("F5238365-2E55-4A19-9356-D0A2011F4F5C"),
                    AssignmentTitle = "Database Project",
                    Description = "Project 2",
                    CourseID = "IS690850"
                },
                 new CourseAssignmentManagemnetConfiguration
                 {
                     Id = new Guid("08104DCB-F230-4726-9D06-06B04B4F168B"),
                     AssignmentTitle = "Calculator",
                     Description = "Project 3",
                     CourseID = "IS690850"
                 }
            );
        }
    }
}
