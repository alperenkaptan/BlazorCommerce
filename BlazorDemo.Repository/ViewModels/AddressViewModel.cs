using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.ViewModels
{
    public class AddressViewModel : BaseViewModel
    {
        public string StressAddress { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string ZipCode { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
    }
}
