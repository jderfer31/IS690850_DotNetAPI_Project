using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class SectionEnrollmentManagementConfiguration : IEntityTypeConfiguration<User>
    {

        private Guid Id;
        private string SectionID;
        private string UserID;
        private string CreatedDate;
        private string UpdatedDate;
        private string StartDate;
        private string EndDate;


        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new SectionEnrollmentManagementConfiguration
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    SectionID = "IS690850",
                    UserID = "06-24-2020",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                    StartDate = "06-24-2020",
                    EndDate = "06-24-2020"
                },
                new SectionEnrollmentManagementConfiguration
                {
                    Id = new Guid("83D146E6-B592-4A15-8137-AA17E17FEC67"),
                    SectionID = "IS690850",
                    UserID = "06-24-2020",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020",
                    StartDate = "06-24-2020",
                    EndDate = "06-24-2020"
                },
                 new SectionEnrollmentManagementConfiguration
                 {
                     Id = new Guid("03E83292-076E-4931-91FC-5696325DB1BA"),
                     SectionID = "IS690850",
                     UserID = "06-24-2020",
                     CreatedDate = "06-24-2020",
                     UpdatedDate = "06-24-2020",
                     StartDate = "06-24-2020",
                     EndDate = "06-24-2020"
                 }
            );
        }

        private class SectionEnrollment
        {
            internal string UserID;
            internal string SectionID;

            public Guid Id { get; set; }
            public string CourseID { get; set; }
            public string StartDate { get; set; }
            public string EndDate { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
        }
    }
}

