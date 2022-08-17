using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.ViewModels
{
    public  class CustomerViewModel : BaseViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
        public ICollection<EmailViewModel> Emails { get; set; }
        public ICollection<AddressViewModel> Addresses { get; set; }
        public ICollection<PhoneViewModel> Phones { get; set; }
    }
}
