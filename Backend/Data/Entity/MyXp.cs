
using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class MyXp
    {
        [Key]
        public int MyXpId { get; set; }
        
        [Display(Name = "عنوان تجربه")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(20)]
        public string Title { get; set; }
        
        [Display(Name = "درصد پیشرفت")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(100)]
        public int value { get; set; }
    }
}