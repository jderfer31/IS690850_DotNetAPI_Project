using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities.Models
{
    class CourseManagement
    {
            [Column("CourseManagementId")]
            public Guid Id { get; set; }

            [Required(ErrorMessage = "Course Management name is a required field.")]
            [MaxLength(30, ErrorMessage = "Maximum length for the Name is 30 characters.")]
            public string CourseTitle { get; set; }
            public string Description { get; set; }
            public string CreatedDate { get; set; }
            public string UpdatedDate { get; set; }
            

            [ForeignKey(nameof(Organization))]
            public Guid OrganizationId { get; set; }

            public Organization Organization { get; set; }
        
    }







}
