using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Configuration
{
    public class SectionAssignmentSubmissionManagementConfiguration : IEntityTypeConfiguration<User>
    {

        private Guid Id;
        private string SectionID;
        private string AssignmentID;
        private string UserID;
        private string SubmissionText;
        private string Score;
        private string CreatedDate;
        private string UpdatedDate;



        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData
            (
                new SectionAssignmentSubmissionManagementConfiguration
                {
                    Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
                    SectionID = "IS690850",
                    AssignmentID = "4321",
                    UserID = "jl822",
                    SubmissionText = "TEXT",
                    Score = "88",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020"
                },
                new SectionAssignmentSubmissionManagementConfiguration
                {
                    Id = new Guid("98166C17-A069-452B-9474-DFCE276EA887"),
                    SectionID = "IS690850",
                    AssignmentID = "1234",
                    UserID = "jl824",
                    SubmissionText = "TEXT",
                    Score = "92",
                    CreatedDate = "06-24-2020",
                    UpdatedDate = "06-24-2020"
                },
                 new SectionAssignmentSubmissionManagementConfiguration
                 {
                     Id = new Guid("9596A9A3-25BC-4F80-8093-B0ABBD888241"),
                     SectionID = "IS690850",
                     AssignmentID = "5678",
                     UserID = "jl826",
                     SubmissionText = "TEXT",
                     Score = "72",
                     CreatedDate = "06-24-2020",
                     UpdatedDate = "06-24-2020"
                 }
            );
        }

        private class SectionAssignmentSubmission
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

