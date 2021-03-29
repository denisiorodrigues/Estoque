using DR.Business.Interfaces;
using DR.Business.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DR.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .FirstOrDefaultAsync(q => q.Id == id);
        }

        public Task<IEnumerable<Produto>> ObterProdutoFornecedores()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            throw new NotImplementedException();
        }
    }
}
