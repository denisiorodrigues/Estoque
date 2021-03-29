using DR.Business.Models;
using System;
using System.Threading.Tasks;

namespace DR.Business.Interfaces
{
    public interface IFornecedoRepository : IRepository<Fornecedor>
    {
        Task<Fornecedor> ObterFornecedorEndereco(Guid id);
        Task<Fornecedor> ObterFornecedorProdutosEndereco(Guid id);
    }
}