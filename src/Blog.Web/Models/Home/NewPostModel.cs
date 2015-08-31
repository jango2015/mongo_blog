using System.ComponentModel.DataAnnotations;

namespace Blog.Web.Models.Home
{
    public class NewPostModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Title { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Tags { get; set; }
    }
}