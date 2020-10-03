using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    class CountWordsQuaryHandler : IRequestHandler<CountWordsQuary, TextViewModel>
    {
        public CountWordsQuaryHandler()
        {
            
        }

        public async Task<TextViewModel> Handle(CountWordsQuary request, CancellationToken cancellationToken)
        {
            var text = Text.Create(request.Content);
            var wordsCount = text.CountWords();

            var viewModel = new TextViewModel {
                WordsCount = wordsCount
            };

            return viewModel;
        }
    }
}
