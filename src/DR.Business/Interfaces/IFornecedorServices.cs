using DR.Business.Models;
using System;
using System.Threading.Tasks;

namespace DR.Business.Interfaces
{
    public interface IFornecedorServices
    {
        Task Adicionar(Fornecedor fornecedor);
        Task Atualizar(Fornecedor fornecedor);
        Task Remover(Guid id);
        Task AtualizarEndereco(Endereco endereco);
    }
}