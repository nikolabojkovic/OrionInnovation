using AutoMapper;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    public class TextProfile : Profile
    {
        public TextProfile()
        {
            CreateMap<Text, TextViewModel>();
        }
    }
}