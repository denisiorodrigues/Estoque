using DR.Business.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace DR.Data.Context
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options)
            : base(options)
        {

        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Fornecedor> Fornecedores { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Se não informar no fluent, ele adiciona esse tipo a todas as tabelas
            //foreach (var property in modelBuilder.Model.GetEntityTypes()
            //    .SelectMany(e => e.GetProperties()
            //    .Where(p => p.ClrType == typeof(string))))
            //    property.SetColumnType("varchar(100)");

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MeuDbContext).Assembly);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys())) relationship.DeleteBehavior = DeleteBehavior.ClientSetNull;

            base.OnModelCreating(modelBuilder);
        }

        /// <summary>
        /// Adicionando essa configuração por conta de um erro de tracking
        /// Solução:
        /// https://wilsonsantosnet.medium.com/entity-framework-enablesensitivedatalogging-72a79639820b
        /// </summary>
        /// <param name="optionsBuilder">Parametro de configuração</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();

            base.OnConfiguring(optionsBuilder);
        }
    }
}