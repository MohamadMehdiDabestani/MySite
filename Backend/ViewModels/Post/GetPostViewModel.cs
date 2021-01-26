using System.Collections.Generic;
namespace Backend.ViewModels
{
    public class GetPostViewModel
    {
        public int id { get; set; }
        
        public string Title { get; set; }

        public string ImageName { get; set; }

        public string AltImage { get; set; }

        public string Description { get; set; }

        public string Text { get; set; }

        public List<string> Tags { get; set; }

        public string Category { get; set; }

        public string CreateDate { get; set; }

    }
}