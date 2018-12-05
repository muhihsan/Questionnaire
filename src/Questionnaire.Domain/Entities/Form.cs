namespace Questionnaire.Domain.Entities
{
    public class Form : BaseEntity
    {
        public string Title { get; private set; }

        public string Description { get; private set; }

        public Form(string title, string description)
        {
            Title = title;
            Description = description;
        }
    }
}
