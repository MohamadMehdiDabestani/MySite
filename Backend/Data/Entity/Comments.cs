using System;
using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class Comments
    {
        [Key]
        public int CommentId { get; set; }
        [Display(Name = "عنوان نظر")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public string CommentTitle { get; set; }
        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200)]
        public string CommentText { get; set; }

        public bool IsShowing { get; set; }
        [Display(Name = "تاریخ ثبت")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public DateTime CreateDate { get; set; }


    }
}