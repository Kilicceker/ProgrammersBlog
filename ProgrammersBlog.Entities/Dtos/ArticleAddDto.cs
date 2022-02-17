using ProgrammersBlog.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Entities.Dtos
{
    public class ArticleAddDto
    {
        [DisplayName("Title")]
        [Required(ErrorMessage="{0} not be null")]
        [MaxLength(100,ErrorMessage = "{0} area  will biger then {1}")]
        [MinLength(5, ErrorMessage = "{0} area  will smaller then {1}")]
        public string Title { get; set; }

        [DisplayName("Content")]
        [Required(ErrorMessage = "{0} not be null")]
        [MinLength(5, ErrorMessage = "{0} area  will smaller then {1}")]
        public string Content { get; set; }

        [DisplayName("Thumbnail")]
        [Required(ErrorMessage = "{0} not be null")]
        [MaxLength(250, ErrorMessage = "{0} area  will biger then {1}")]
        [MinLength(5, ErrorMessage = "{0} area  will smaller then {1}")]
        public string Thumbnail { get; set; }

        [DisplayName("Date")]
        [Required(ErrorMessage = "{0} not be null")]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString="{0:dd/MM/yyyy}")]
        public DateTime Date { get; set; }

        [DisplayName("Seo Author")]
        [Required(ErrorMessage = "{0} not be null")]
        [MaxLength(50, ErrorMessage = "{0} area  will biger then {1}")]
        [MinLength(0, ErrorMessage = "{0} area  will smaller then {1}")]
        public string SeoAuthor { get; set; }

        [DisplayName("Seo Description")]
        [Required(ErrorMessage = "{0} not be null")]
        [MaxLength(150, ErrorMessage = "{0} area  will biger then {1}")]
        [MinLength(0, ErrorMessage = "{0} area  will smaller then {1}")]
        public string SeoDescription { get; set; }

        [DisplayName("Seo Tags")]
        [Required(ErrorMessage = "{0} not be null")]
        [MaxLength(70, ErrorMessage = "{0} area  will biger then {1}")]
        [MinLength(0, ErrorMessage = "{0} area  will smaller then {1}")]
        public string SeoTags { get; set; }

        [DisplayName("Category")]
        [Required(ErrorMessage = "{0} not be null")]
        public int CategoryId { get; set; }

        public Category Category { get; set; }

        [DisplayName("Is Active")]
        [Required(ErrorMessage = "{0} not be null")]
        public bool IsActive { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}
