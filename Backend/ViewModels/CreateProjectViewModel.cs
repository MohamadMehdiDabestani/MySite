using System.ComponentModel.DataAnnotations;

namespace Backend.ViewModels
{
    public class CreateProjectViewModel
    {

        [Display(Name = "زمینه ی پروژه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Environment { get; set; }

        [Display(Name = "زمینه های پروژه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Technology { get; set; }

        [Display(Name = "قیمت")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public int Price { get; set; }

        [Display(Name = "زمان")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]

        public string Time { get; set; }

        [Display(Name = "شماره ی همراه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(11 , ErrorMessage="شماره ی تلفن هراه باید 11 رقمی باشد")]
        [MinLength(11 , ErrorMessage="شماره ی تلفن هراه باید 11 رقمی باشد")]
        public string Phone { get; set; }

        [Display(Name = "ایمیل")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [EmailAddress(ErrorMessage = "یک ایمیل معتبر وارد کنید")]
        public string Email { get; set; }
        [Display(Name = "نام")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Name { get; set; }
        [Display(Name = "توضیحات")]
        
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public string Text { get; set; }

        public bool IsWhatsapp { get; set; }

        public bool IsTelegram { get; set; }

        public bool IsEmail { get; set; }
    }
}