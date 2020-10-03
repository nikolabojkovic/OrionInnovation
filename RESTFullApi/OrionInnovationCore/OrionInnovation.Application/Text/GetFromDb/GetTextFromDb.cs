using System;
using MediatR;

namespace OrionInnovation.Application
{
    public class GetTextFromDbQuary : IRequest<TextViewModel>
    {
        public int Id { get; set; }
    }
}
