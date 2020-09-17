using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    [CourseTitleDescriptionMustBeDifferentDescription]
    public class CourseForCreationDto
    {
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [MaxLength(1500)]
        public string Description { get; set; }
    }
}