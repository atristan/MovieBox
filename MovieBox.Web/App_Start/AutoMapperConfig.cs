#region Includes

// MovieBox.Web Libraries
using MovieBox.Web.Models.Entities;

// AutoMapper
using AutoMapper;

// MovieBox Libraries
using Entities;

#endregion

namespace MovieBox.Web.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Start()
        {
            //MapperConfiguration mapperCfg = new MapperConfiguration(cfg => { cfg.CreateMap<Customer, DisplayCustomer>(); });
            //IMapper mapper = mapperCfg.CreateMapper();

            Mapper.Initialize(cfg => cfg.CreateMap<Customer, DisplayCustomer>());
        }
    }
}