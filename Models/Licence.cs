using System.ComponentModel.DataAnnotations;

namespace Walnut_API.Models
{
    public class Licence
    {
        [Key]
        public int Id { get; set; }
        public string LicenceKey { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
