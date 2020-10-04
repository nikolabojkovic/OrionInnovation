using System;
using OrionInnovation.Domain;

namespace OrionInnovation.Application
{
    public class DateTimeProvider : IDateTimeProvider
    {
        public DateTime Now { get => DateTime.Now; }
    }
}