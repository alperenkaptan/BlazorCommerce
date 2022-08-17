using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.ViewModels
{
    public class EmailViewModel : BaseViewModel
    {
        public string EmailAddress { get; set; }
        public virtual CustomerViewModel Customer { get; set; }
    }
}
