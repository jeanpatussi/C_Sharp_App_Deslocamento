﻿using AppDeslocamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppDeslocamento.Data.Mapping
{
    public class CondutorConfiguration : IEntityTypeConfiguration<Condutor>
    {
        public void Configure(EntityTypeBuilder<Condutor> builder)
        {
            builder.ToTable("condutores");

            builder.HasKey(e => e.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnName("nome")
                .HasMaxLength(100);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasColumnName("email")
                .HasMaxLength(100);
        }
    }
}
