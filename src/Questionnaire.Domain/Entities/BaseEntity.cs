using System;

namespace Questionnaire.Domain.Entities
{
    public class BaseEntity
    {
        public string Id { get; }

        public DateTimeOffset CreatedDate { get; }

        public DateTimeOffset UpdatedDate { get; }
    }
}
