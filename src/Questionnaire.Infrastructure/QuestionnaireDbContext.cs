using Microsoft.EntityFrameworkCore;
using Questionnaire.Domain.Entities;
using Questionnaire.Infrastructure.Configurations;

namespace Questionnaire.Infrastructure
{
    public class QuestionnaireDbContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }

        public QuestionnaireDbContext(DbContextOptions<QuestionnaireDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FormConfiguration());
        }
    }
}
