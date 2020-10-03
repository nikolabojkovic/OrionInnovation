using System;
using MediatR;

namespace OrionInnovation.Application
{
    public class CountWordsQuary : IRequest<TextViewModel>
    {
        public string Content { get; set; }
    }
}
