using System.ComponentModel.DataAnnotations;
using CourseLibrary.API.ValidationAttributes;

namespace CourseLibrary.API.Models
{
    public class CourseForUpdateDto : CourseForManipulationDto
    {
        [Required(ErrorMessage = "For Description null error message")]
        public override string Description
        {
            get => base.Description;
            set => base.Description = value;
        }
    }
}