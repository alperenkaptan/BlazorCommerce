using System.ComponentModel.DataAnnotations;

namespace BlazorDemo.Domain.SeedWorks
{
    public  class BaseModel
    {
        public int Id { get; set; }
        [Required]
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [Required]
        public bool IsActive { get; set; }
    }
}
