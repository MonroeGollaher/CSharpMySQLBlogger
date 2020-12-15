using System.ComponentModel.DataAnnotations;

namespace CSharpBlogger.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(80)]
        public string Title { get; set; }
        [Required]
        [MaxLength(50)]
        public string  Author { get; set; }
        [Required]
        [MaxLength(80)]
        public string Description { get; set; }
        public bool IsPublished { get; set; }
    }
}