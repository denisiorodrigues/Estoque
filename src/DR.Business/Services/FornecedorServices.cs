using DR.Business.Interfaces;
using DR.Business.Models;
using DR.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DR.Business.Services
{
    public class FornecedorServices : BaseServices, IFornecedorServices
    {
        public async Task Adicionar(Fornecedor fornecedor)
        {
            // Validar estado da entidade
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)
                && ExecutarValidacao(new EnderecoValidation(), fornecedor.Endereco))return ;

            // se não existe fornecedor com o mesmo documento
        }

        public async Task Atualizar(Fornecedor fornecedor)
        {
            if (!ExecutarValidacao(new FornecedorValidation(), fornecedor)) return;
        }

        public async Task AtualizarEndereco(Endereco endereco)
        {
            if (!ExecutarValidacao(new EnderecoValidation(), endereco)) return;
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}