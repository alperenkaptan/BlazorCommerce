using BlazorDemo.Domain.SeedWorks;
using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Domain.Models
{
    public class Customer : BaseModel
    {
        [Required]
        [MaxLength(250)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(250)]
        public string LastName { get; set; }
        [Required]
        [MaxLength(250)]
        public string UserName { get; set; }
        [Required]
        [MaxLength(250)]
        public string Password { get; set; }
        [Required]
        public DateTime Birthday { get; set; }

        public virtual ICollection <Email> Emails { get; set; }
        public virtual ICollection <Address> Addresses { get; set; }
        public virtual ICollection <Phone> Phones { get; set; }
    }
}
