using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseManagementConfiguration : IEntityTypeConfiguration<User>
    {
        private string CourseTitle;
        private string Description;
        private string CreatedDate;
        private string UpdatedDate;
        private Guid Id;

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new CourseManagementConfiguration
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    CourseTitle = "Web Services and Middleware",
                    Description = "Visual Studio",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",

                },
                new CourseManagementConfiguration
                {
                    Id = new Guid("9401DF51-43F7-4C89-98B9-95BD7380C02B"),
                    CourseTitle = "Web Systems",
                    Description = "Pycharm",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                },
                 new CourseManagementConfiguration
                 {
                     Id = new Guid("C717E3A5-CE38-4B86-9CD0-9702CE3C48E8"),
                     CourseTitle = "Web Systems",
                     Description = "Pycharm",
                     CreatedDate = "06-24-2020",
                     UpdatedDate = "06-24-2020",
                 }
            );
        }
    }
}
