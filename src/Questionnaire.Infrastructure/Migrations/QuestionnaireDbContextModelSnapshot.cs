﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Questionnaire.Infrastructure;

namespace Questionnaire.Infrastructure.Migrations
{
    [DbContext(typeof(QuestionnaireDbContext))]
    partial class QuestionnaireDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Questionnaire.Domain.Entities.Form", b =>
                {
                    b.Property<string>("_id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id");

                    b.Property<string>("Description");

                    b.Property<string>("Title");

                    b.HasKey("_id");

                    b.ToTable("Forms");
                });
#pragma warning restore 612, 618
        }
    }
}