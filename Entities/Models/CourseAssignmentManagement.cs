using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Xunit;

namespace Entities.Models
{
        class CourseAssignmentManagement
    {
        [Column("CourseAssignmentManagementId")]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Course Assignment Management name is a required field.")]
        [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
        public string AssignmentTitle { get; set; }
        public string Description { get; set; }
        public string CourseID { get; set; }
       


        [ForeignKey(nameof(Organization))]
        public Guid OrganizationId { get; set; }

        public Organization Organization { get; set; }

        private class RequiredAttribute : Attribute
        {
            public string ErrorMessage;
        }
    }







}
