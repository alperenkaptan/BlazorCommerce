using BlazorDemo.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Domain.Models
{
    public class Address : BaseModel
    {
        [Required]
        [MaxLength(250)]
        public string StressAddress { get; set; }
        [Required]
        [MaxLength(250)]
        public string City { get; set; }
        [Required]
        [MaxLength(250)]
        public string County { get; set; }
        [Required]
        [MaxLength(250)]
        public string ZipCode { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }

    }
}
