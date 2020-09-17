using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    [CourseTitleDescriptionMustBeDifferentDescription(ErrorMessage = "Custom Validation file error message")]
    public abstract class CourseForManipulationDto
    {
        [Required(ErrorMessage = "For Title null error message")]
        [MaxLength(100, ErrorMessage = "For Title maxlength error message")]
        public virtual string Title { get; set; }
        
        [Required(ErrorMessage = "For Description null error message")]
        [MaxLength(500, ErrorMessage = "For Description maxlength error message")]
        public virtual string Description { get; set; }
    }
}