using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    class CountWordsQuaryHandler : IRequestHandler<CountWordsQuary, TextViewModel>
    {
        public CountWordsQuaryHandler() { }

        public Task<TextViewModel> Handle(CountWordsQuary request, CancellationToken cancellationToken)
        {
            if (request.Content == null)
                throw new BadRequestException("Text is required");

            var text = Text.Create(request.Content);
            var wordsCount = text.CountWords();

            var viewModel = new TextViewModel {
                Content = request.Content,
                WordsCount = wordsCount
            };

            return Task.FromResult(viewModel);
        }
    }
}
