using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;
using AutoMapper;
using System.Collections.Generic;

namespace OrionInnovation.Application
{
    class GetTextQuaryHandler : IRequestHandler<GetTextFromDbQuary, TextViewModel>
    {
        private readonly ITextRepository _textRepository;
        private readonly IMapper _mapper;

        public GetTextQuaryHandler(IEnumerable<ITextRepository> textRepositories,
            IMapper mapper) 
        {
            _textRepository = textRepositories.First(repo => repo.ToString().Contains("TextSqlDbRepository"));
            _mapper = mapper;
        }

        public async Task<TextViewModel> Handle(GetTextFromDbQuary request, CancellationToken cancellationToken)
        {
            var text = await _textRepository.GetById(request.Id);

            if (text == null)
                throw new NotFoundException(nameof(Text), request.Id);

            return _mapper.Map<TextViewModel>(text);
        }
    }
}
