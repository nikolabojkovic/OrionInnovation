using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;
using AutoMapper;

namespace OrionInnovation.Application
{
    class GetTextQuaryHandler : IRequestHandler<GetTextFromDbQuary, TextViewModel>
    {
        private readonly ITextRepository _textRepository;
        private readonly IMapper _mapper;

        public GetTextQuaryHandler(ITextRepository textRepository,
            IMapper mapper) 
        {
            _textRepository = textRepository;
            _mapper = mapper;
        }

        public async Task<TextViewModel> Handle(GetTextFromDbQuary request, CancellationToken cancellationToken)
        {
            var text = await _textRepository.GetById(1);

            if (text == null)
                throw new BadRequestException("Text is required");

            return _mapper.Map<TextViewModel>(text);
        }
    }
}
