using System;
namespace Questionnaire.Domain.Entities
{
    public class Form : BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }
    }
}
