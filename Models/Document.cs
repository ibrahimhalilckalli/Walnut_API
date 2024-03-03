using System.ComponentModel.DataAnnotations;

namespace Walnut_API.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string FilePath { get; set; }
        public string DisplayName { get; set; }
    }
}
