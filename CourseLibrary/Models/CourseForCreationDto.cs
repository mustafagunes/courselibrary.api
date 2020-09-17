using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    [CourseTitleDescriptionMustBeDifferentDescription(ErrorMessage = "Custom Validation file error message")]
    public class CourseForCreationDto
    {
        [Required(ErrorMessage = "For Title null error message")]
        [MaxLength(100, ErrorMessage = "For Title maxlength error message")]
        public string Title { get; set; }
        
        [MaxLength(500, ErrorMessage = "For Description error message")]
        public string Description { get; set; }
    }
}