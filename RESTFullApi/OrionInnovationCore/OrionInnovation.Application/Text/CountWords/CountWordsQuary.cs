using System;
using MediatR;

namespace OrionInnovation.Application
{
    public class CountWordsQuary : IRequest<WordsCountViewModel>
    {
        public string Content { get; set; }
    }
}
