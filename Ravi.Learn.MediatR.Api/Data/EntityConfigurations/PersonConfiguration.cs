using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ravi.Learn.MediatR.Api.Data.Entities;
using System;


namespace Ravi.Learn.MediatR.Api.Data.EntityConfigurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person", "dbo");
            builder.HasKey(b => b.Id).IsClustered();

            builder.Property(b => b.Id).HasColumnName("PersonKey").ValueGeneratedOnAdd();

            builder.Property(b => b.FirstName)
                    .HasColumnName("FirstName").HasMaxLength(50).IsRequired();

            builder.Property(b => b.FirstName)
                    .HasColumnName("FirstName").HasMaxLength(50).IsRequired();


        }
    }
}
