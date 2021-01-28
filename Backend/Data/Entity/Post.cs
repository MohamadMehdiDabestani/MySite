using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
namespace Backend.Data
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }

        [Display(Name = "عنوان پست")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(70)]
        public DateTime CreateData { get; set; }

        [Display(Name = "متن کوتاه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200)]
        public string Description { get; set; }

        [Display(Name = "متن")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Text { get; set; }

        [Display(Name = "کلمات کلیدی")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200)]
        public string Tags { get; set; }

        [Display(Name = "گروه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(150)]
        public string Category { get; set; }

        [Display(Name = "نام عکس")]
        [MaxLength(150)]
        public string imageName { get; set; }

        [Display(Name = "متن جایگزین عکس")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(150)]
        public string AltImage { get; set; }

        [Display(Name = "متن جایگزین عکس")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public string TitleOfBrowser { get; set; }
    }

}