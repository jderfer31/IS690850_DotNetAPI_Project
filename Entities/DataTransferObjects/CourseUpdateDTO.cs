using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.DataTransferObjects
{
    public class CourseUpdateDTO
    {
        [Required(ErrorMessage = "CourseName is a required field.")]
        [MaxLength(25, ErrorMessage = "Maximum length for the CourseName is 25 characters.")]
        [MinLength(10, ErrorMessage = "Minimum length for the CourseName is 10 characters.")]
        public string CourseName { get; set; }

        [Required(ErrorMessage = "Description is a required field.")]
        [MaxLength(50, ErrorMessage = "Maximum length for the Description is 50 characters.")]
        [MinLength(10, ErrorMessage = "Minimum length for the Description is 10 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Description is a required field.")]
        public DateTime CreatedDate { get; set; }

        [Required(ErrorMessage = "Description is a required field.")]
        public DateTime UpdatedDate { get; set; }

    }
}