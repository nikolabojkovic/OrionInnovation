using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    class CountWordsQuaryHandler : IRequestHandler<CountWordsQuary, WordsCountViewModel>
    {
        public CountWordsQuaryHandler() { }

        public Task<WordsCountViewModel> Handle(CountWordsQuary request, CancellationToken cancellationToken)
        {
            if (request.Content == null)
                throw new BadRequestException("Text is required");

            var text = Text.Create(request.Content, DateTime.Now);
            var wordsCount = text.CountWords();

            var viewModel = new WordsCountViewModel {
                WordsCount = wordsCount
            };

            return Task.FromResult(viewModel);
        }
    }
}
