using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace Backend.ViewModels
{
    public class EditePostViewModel
    {
        [Required]
        public int id { get; set; }
        
        [Display(Name = "عنوان پست")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public string Title { get; set; }
        
        [Display(Name = "متن کوتاه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200)]
        public string Description { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Text { get; set; }
        
        [Required]
        public string ImageName { get; set; }
        
        [Display(Name = "متن جایگزین عکس")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(150)]
        public string AltImage { get; set; }
        
        [Display(Name = "متن جایگزین عکس")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public IFormFile NewImage { get; set; }
        
        [Display(Name = "کلمات کلیدی")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200)]
        public string Tages { get; set; }
        
        [Display(Name = "گروه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(150)]
        public string Category { get; set; }
    }
}