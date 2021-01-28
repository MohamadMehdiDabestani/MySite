using System.ComponentModel.DataAnnotations;

namespace Backend.ViewModels
{
    public class DeleteXp
    {
        [Display(Name = "عنوان تجربه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(20)]
        public string Title { get; set; }
    }
}