using DR.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DR.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutoFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);
    }
}