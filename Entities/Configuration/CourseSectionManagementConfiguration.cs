using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseSectionManagementConnfiguration : IEntityTypeConfiguration<User>
    {

        private Guid Id;
        private string CourseID;
        private string StartDate;
        private string EndDate;
        private string CreatedDate;
        private string UpdatedDate;



        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new CourseSectionManagemnetConfiguration
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    CourseID = "IS690850",
                    StartDate = "06-24-2020",
                    EndDate = "06-24-2020",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",

                },
                new CourseSectionManagemnetConfiguration
                {
                    Id = new Guid("6B9FB962-DBCA-4943-8DED-DBF63DF9990C"),
                    CourseID = "IS601850",
                    StartDate = "06-24-2020",
                    EndDate = "06-24-2020",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                },
                 new CourseSectionManagemnetConfiguration
                 {
                     Id = new Guid("1A4D3341-3A7B-402F-BCF2-BC577F9C2F11"),
                     CourseID = "IS601850",
                     StartDate = "06-24-2020",
                     EndDate = "06-24-2020",
                     CreatedDate = "06-24-2020",
                     UpdatedDate = "06-24-2020",
                 }
            );
        }

        private class CourseSectionManagemnetConfiguration
        {
            public Guid Id { get; set; }
            public string CourseID { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
        }
    }
}

