using System.ComponentModel.DataAnnotations;

namespace PruebaEFCore.Domain.Model
{
    /// <summary>
    /// Blog entity
    /// </summary>
    public class BlogDto
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public DateTime DateTimeAdd { get; set; }
    }
}