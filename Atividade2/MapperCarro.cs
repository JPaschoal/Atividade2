using AutoMapper;

namespace Atividade2
{
    public class MapperCarro : Profile
    {
        public MapperCarro()
        {
            CreateMap<Carro, CarroDTO>()
                .ForMember(dest => dest.AnoFabricaçao, opt => opt.MapFrom(src => src.Ano.ToString()));
        }
    }
}
