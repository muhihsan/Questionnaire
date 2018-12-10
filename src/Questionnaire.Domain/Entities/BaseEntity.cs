namespace Questionnaire.Domain.Entities
{
    public abstract class BaseEntity
    {
        private string _id;

        public string Id { get => _id; }
    }
}
