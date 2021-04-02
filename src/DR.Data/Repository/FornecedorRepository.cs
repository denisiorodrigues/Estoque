using DR.Business.Interfaces;
using DR.Business.Models;
using DR.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DR.Data.Repository
{
    public class FornecedorRepository : Repository<Fornecedor>, IFornecedorRepository
    {
        
        public FornecedorRepository(MeuDbContext context)
            :base(context)
        { }

        public async Task<Fornecedor> ObterFornecedorEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }

        public async Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id)
        {
            return await Db.Fornecedores.AsNoTracking()
                .Include(f => f.Produtos)
                .Include(f => f.Endereco)
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}