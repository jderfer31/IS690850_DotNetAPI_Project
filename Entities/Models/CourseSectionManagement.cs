using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Xunit;

namespace Entities.Models
{
    class CourseSectionManagement
    {
        [Column("CourseSectionManagementID")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Course Section Management name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string CourseID { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string CreatedDate { get; set; }
        public string UpdatedDate { get; set; }



        [ForeignKey(nameof(Organization))]
        public Guid OrganizationId { get; set; }

        public Organization Organization { get; set; }

        private class RequiredAttribute : Attribute
        {
            public string ErrorMessage;
        }
    }







}

