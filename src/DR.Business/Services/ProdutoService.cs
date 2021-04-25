using DR.Business.Interfaces;
using DR.Business.Models;
using DR.Business.Models.Validations;
using System;
using System.Threading.Tasks;

namespace DR.Business.Services
{
    public class ProdutoService : BaseServices, IProdutoService
    {
        public async Task Adicionar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Atualizar(Produto produto)
        {
            if (!ExecutarValidacao(new ProdutoValidation(), produto)) return;
        }

        public async Task Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}