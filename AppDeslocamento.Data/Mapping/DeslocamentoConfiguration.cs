using AppDeslocamento.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppDeslocamento.Data.Mapping
{
    internal class DeslocamentoConfiguration : IEntityTypeConfiguration<Deslocamento>
    {
        public void Configure(EntityTypeBuilder<Deslocamento> builder)
        {
            builder.ToTable("deslocamentos");

            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.Cliente)
                .WithMany(d => d.Deslocamentos)
                .HasForeignKey(e => e.ClienteId)
                .HasConstraintName("FK_Cliente_Deslocamentos_clienteId");

            builder.HasOne(p => p.Condutor)
                .WithMany(d => d.Deslocamentos)
                .HasForeignKey(e => e.CondutorId)
                .HasConstraintName("FK_Condutor_Deslocamentos_condutorId");

            builder.HasOne(p => p.Veiculo)
                .WithMany(d => d.Deslocamentos)
                .HasForeignKey(e => e.VeiculoId)
                .HasConstraintName("FK_Veiculo_Deslocamentos_veiculoId");

            builder.Property(p => p.DataHoraInicio)
                .IsRequired()
                .HasColumnName("dataHoraInicio")
                .HasColumnType("datetime");

            builder.Property(p => p.KmInicio)
                .IsRequired()
                .HasColumnName("kmInicio");

            builder.Property(p => p.Observacao)
                .HasColumnName("observacao")
                .HasMaxLength(300);

            builder.Property(p => p.DataHoraFim)
                .HasColumnName("dataHoraFim")
                .HasColumnType("datetime");

            builder.Property(p => p.KmFim)
                .HasDefaultValue(0)
                .HasColumnName("kmFim");
        }
    }
}
