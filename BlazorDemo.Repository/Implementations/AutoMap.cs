using AutoMapper;
using BlazorDemo.Domain.SeedWorks;
using BlazorDemo.Repository.Interfaces;
using BlazorDemo.Repository.SeedWorks;

namespace BlazorDemo.Repository.Implementations
{
    public class AutoMap : IAutoMap
    {
        public AutoMap()
        {

        }

        public Destination MapModelToView<Source, Destination>(Source src) where Source : BaseModel where Destination : BaseViewModel
        {
            var mapper = new MapperConfiguration(m => m.CreateMap<Source, Destination>()).CreateMapper();
            var result = mapper.Map<Source, Destination>(src);
            return result;
        }

        public List<Destination> MapModelToViewList<Source, Destination>(List<Source> src) where Source : BaseModel where Destination : BaseViewModel
        {
            var mapper = new MapperConfiguration(m => m.CreateMap<Source, Destination>()).CreateMapper();
            var result = mapper.Map<List<Source>, List<Destination>>(src);
            return result;
        }

        public Destination MapViewToModel<Source, Destination>(Source src) where Source : BaseViewModel where Destination : BaseModel
        {
            var mapper = new MapperConfiguration(m => m.CreateMap<Source, Destination>()).CreateMapper();
            var result = mapper.Map<Source, Destination>(src);
            return result;
        }

        public List<Destination> MapViewToModelList<Source, Destination>(List<Source> src) where Source : BaseViewModel where Destination : BaseModel
        {
            var mapper = new MapperConfiguration(m => m.CreateMap<Source, Destination>()).CreateMapper();
            var result = mapper.Map<List<Source>, List<Destination>>(src);
            return result;
        }


    }
}
