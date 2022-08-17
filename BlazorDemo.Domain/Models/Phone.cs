using BlazorDemo.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Domain.Models
{
    public class Phone : BaseModel
    {
        [Required]
        [MaxLength(250)]
        public string PhoneNumber { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
    }
}
