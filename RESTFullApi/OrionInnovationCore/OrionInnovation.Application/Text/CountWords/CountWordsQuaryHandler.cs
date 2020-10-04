using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    class CountWordsQuaryHandler : IRequestHandler<CountWordsQuary, WordsCountViewModel>
    {
        private readonly IDateTimeProvider _dateTimeProvider;
        public CountWordsQuaryHandler(IDateTimeProvider dateTimeProvider)
        {
            _dateTimeProvider = dateTimeProvider;
        }

        public Task<WordsCountViewModel> Handle(CountWordsQuary request, CancellationToken cancellationToken)
        {
            if (request.Content == null)
                throw new BadRequestException("Text is required");

            var text = Text.Create(request.Content, _dateTimeProvider.Now);
            var wordsCount = text.CountWords();

            var viewModel = new WordsCountViewModel {
                WordsCount = wordsCount
            };

            return Task.FromResult(viewModel);
        }
    }
}
