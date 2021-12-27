using System.ComponentModel.DataAnnotations;

namespace PruebaEFCore.ViewModel
{
    /// <summary>
    /// Blog entity
    /// </summary>
    public class BlogViewModel
    {
        public int BlogId { get; set; }
        [Required]
        [MaxLength(128)]
        public string Title { get; set; }
        [Required]
        [MaxLength(256)]
        public string SubTitle { get; set; }
        public DateTime DateTimeAdd { get; set; }
    }
}