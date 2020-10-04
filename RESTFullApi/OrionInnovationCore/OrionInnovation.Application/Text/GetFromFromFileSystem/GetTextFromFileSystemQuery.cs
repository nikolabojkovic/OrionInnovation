using System;
using MediatR;

namespace OrionInnovation.Application
{
    public class GetTextFromFileSystemQuery : IRequest<TextViewModel>
    {
        public int Id { get; set; }
    }
}
