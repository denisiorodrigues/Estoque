using DR.Business.Interfaces;
using DR.Business.Models;
using DR.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace DR.Data.Repository
{
    public class EnderecoRepository : Repository<Endereco>, IEnderecoRepository
    {
        public EnderecoRepository(MeuDbContext context)
            :base(context)
        { }

        public async Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId)
        {
            return await Db.Enderecos.FirstOrDefaultAsync(e => e.FornecedorId == fornecedorId);
        }
    }
}