using System;
using System.Net;

namespace OrionInnovation.Application
{
      public class BadRequestException : ApiException
    {
        public BadRequestException(string message) 
            : base(message, HttpStatusCode.BadRequest) {}
    }
}