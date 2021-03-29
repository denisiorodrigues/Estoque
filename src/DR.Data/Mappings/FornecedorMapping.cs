using DR.Business.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DR.Data.Mappings
{
    public class FornecedorMapping : IEntityTypeConfiguration<Fornecedor>
    {
        public void Configure(EntityTypeBuilder<Fornecedor> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.Property(p => p.Documento)
                .IsRequired()
                .HasColumnType("varchar(14)");

            //Configuração 1 para 1
            builder.HasOne(f => f.Endereco)
                .WithOne(e => e.Fornecedor);

            //Configuração de 1 para N -> Fornecedor vários produtos

            builder.HasMany(f => f.Produtos)
                .WithOne(p => p.Fornecedor)
                .HasForeignKey(p => p.ForncedorId);

            builder.ToTable("Fornecedores");
        }
    }
}