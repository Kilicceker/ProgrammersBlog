using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class CategoryUpdateDto
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Category Name")]
        [Required(ErrorMessage = "{0} not be null")]
        [MaxLength(70, ErrorMessage = "{0} {1} dont bigger charecter")]
        [MinLength(3, ErrorMessage = "{0} {1} dont smaller charrecter")]
        public string Name { get; set; }

        [DisplayName("Category Description")]
        [MaxLength(500, ErrorMessage = "{0} {1} dont bigger charecter")]
        [MinLength(3, ErrorMessage = "{0} {1} dont smaller charrecter")]
        public string Description { get; set; }

        [DisplayName("Category Special Note Area")]
        [MaxLength(500, ErrorMessage = "{0} {1} dont bigger charecter")]
        [MinLength(3, ErrorMessage = "{0} {1} dont smaller charrecter")]
        public string Note { get; set; }

        [DisplayName("Is Active?")]
        [Required(ErrorMessage = "{0} not be null")]
        public bool IsActive { get; set; }

        [DisplayName("Is Deleted")]
        [Required(ErrorMessage = "{0} not be null")]
        public bool IsDeleted { get; set; }
    }
}
