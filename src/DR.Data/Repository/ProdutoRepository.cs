using DR.Business.Interfaces;
using DR.Business.Models;
using DR.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DR.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MeuDbContext context) 
            : base(context)
        { }

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutoFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}
