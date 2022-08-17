using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.ViewModels
{
    public class PhoneViewModel : BaseViewModel
    {
        public string PhoneNumber { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
    }
}
