using System.ComponentModel.DataAnnotations.Schema;

namespace AboutMe.Models
{
    [Table("Articles")] 
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}