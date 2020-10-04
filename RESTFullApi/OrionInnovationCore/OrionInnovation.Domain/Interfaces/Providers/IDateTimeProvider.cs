using System;

namespace OrionInnovation.Domain
{
    public interface IDateTimeProvider
    {
        public DateTime Now { get; }
    }
}