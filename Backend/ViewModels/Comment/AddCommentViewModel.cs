using System.ComponentModel.DataAnnotations;

namespace Backend.ViewModels
{
    public class AddCommentViewModel
    {
        [Display(Name = "عنوان نظر")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100,ErrorMessage = "برای {0} باید کمتر از {1} کاراکتر وارد کنید")]

        public string Title { get; set; }

        [Display(Name = "متن نظر")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(200,ErrorMessage = "برای {0} باید کمتر از {1} کاراکتر وارد کنید")]
        public string Text { get; set; }
    }
}