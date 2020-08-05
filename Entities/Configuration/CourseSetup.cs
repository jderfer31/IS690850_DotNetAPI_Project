using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Entities.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Courses>
    {
        public void Configure(EntityTypeBuilder<Courses> builder)
        {
            builder.HasData
            (
                new Courses
                {
                    Id = new Guid("554BD63C-67BD-4ED0-9DC0-8EB95110721C"),
                    CourseName = "Computer Security Auditing",
                    Description = "This course is intended to provide the student with a fundamental knowledge of a number of security control risks and issues that plague industries today. ",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    
                },
                new Courses
                {
                    Id = new Guid("8915734F-9C28-49C4-9474-EB9FC2DD53DC}"),
                    CourseName = "User Experience Design",
                    Description = "Each week of the class will focus on a different UX design concept.",
                    CreatedDate = DateTime.Now,
                    UpdatedDate = DateTime.Now,
                    
                },
                 new Courses
                 {
                     Id = new Guid("54560DA6-A577-4D32-8EA7-A8BFE4F8D036"),
                     CourseName = "	Web Systems Development",
                     Description = "Students will gain experience in the development of Web based systems using an object oriented programming language and SQL.",
                     CreatedDate = DateTime.Now,
                     UpdatedDate = DateTime.Now,
                    
                 }
            );
        }
    }

    public class Courses
    {
        public Guid Id { get; internal set; }
        public string CourseName { get; internal set; }
        public string Description { get; internal set; }
        public DateTime CreatedDate { get; internal set; }
        public DateTime UpdatedDate { get; internal set; }
    }
}