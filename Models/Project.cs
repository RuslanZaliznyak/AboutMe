using System.ComponentModel.DataAnnotations.Schema;

namespace AboutMe.Models
{
    [Table("Projects")]
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string? SourceLink { get; set; }
        public string ImageTitle { get; set; }
        public byte[] ImageData { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}