using BlazorDemo.Domain.SeedWorks;
using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.Interfaces
{
    public interface IAutoMap
    {
        Destination MapModelToView<Source, Destination>(Source src)
            where Source : BaseModel
            where Destination : BaseViewModel;
        List<Destination> MapModelToViewList<Source, Destination>(List<Source> src)
            where Source : BaseModel
            where Destination : BaseViewModel;
        Destination MapViewToModel<Source, Destination>(Source src)
            where Source : BaseViewModel
            where Destination : BaseModel;
        List<Destination> MapViewToModelList<Source, Destination>(List<Source> src)
            where Source : BaseViewModel
            where Destination : BaseModel;
    }
}