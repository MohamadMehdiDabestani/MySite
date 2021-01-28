using System.ComponentModel.DataAnnotations;

namespace Backend.ViewModels
{
    public class AddXp
    {
        [Display(Name = "عنوان تجربه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(20)]
        public string Title { get; set; }

        [Display(Name = "درصد پیشرفت")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        public int Value { get; set; }
    }
}