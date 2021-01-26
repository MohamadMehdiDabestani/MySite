using System.ComponentModel.DataAnnotations;

namespace Backend.Data
{
    public class Projects
    {
        [Key]
        public int ProjectId { get; set; }
        
        [Display(Name = "حالت")]
        [Required(ErrorMessage = "باید {0} را وارد کنید")]
        [MaxLength(70)]
        public string Status { get; set; }
        
        [Display(Name = "آدرس سایت")]
        [MaxLength(100)]
        public string Url { get; set; }
    }
}