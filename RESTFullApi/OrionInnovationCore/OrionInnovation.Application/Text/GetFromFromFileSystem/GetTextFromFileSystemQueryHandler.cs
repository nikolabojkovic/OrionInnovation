using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;
using AutoMapper;
using System.Collections.Generic;

namespace OrionInnovation.Application
{
    class GetTextFromFileSystemQueryHandler : IRequestHandler<GetTextFromFileSystemQuery, TextViewModel>
    {
        private readonly ITextRepository _textRepository;
        private readonly IMapper _mapper;

        public GetTextFromFileSystemQueryHandler(IEnumerable<ITextRepository> textRepositories,
            IMapper mapper) 
        {
            _textRepository = textRepositories.First(repo => repo.ToString().Contains("TextFileSystemRepository"));
            _mapper = mapper;
        }

        public async Task<TextViewModel> Handle(GetTextFromFileSystemQuery request, CancellationToken cancellationToken)
        {
            var text = await _textRepository.GetById(1);

            if (text == null)
                throw new NotFoundException(nameof(Text), request.Id);

            return _mapper.Map<TextViewModel>(text);
        }
    }
}
