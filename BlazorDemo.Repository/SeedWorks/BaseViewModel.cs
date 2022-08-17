
namespace BlazorDemo.Repository.SeedWorks
{
    public class BaseViewModel
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public bool IsActive { get; set; }
    }
}
