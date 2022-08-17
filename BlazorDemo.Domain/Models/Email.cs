using BlazorDemo.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Domain.Models
{
    public class Email : BaseModel
    {
        [Required]
        [MaxLength(250)]
        public string EmailAddress { get; set; }
        [Required]
        public virtual Customer Customer { get; set; }
    }
}
