using System;
using MediatR;

namespace OrionInnovation.Application
{
    public class CountWordsQuary : IRequest<CountWordsViewModel>
    {
        public string Content { get; set; }
    }
}
