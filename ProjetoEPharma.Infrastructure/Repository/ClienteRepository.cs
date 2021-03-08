using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.Model;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Linq;

namespace ProjetoEPharma.Infrastructure.Repository
{
    public class ClienteRepository : GenericRepository<ClienteEntity, CommonModel>, IClienteRepository
    {
        public ClienteRepository(CommonModel context) : base(context) { }

        public async Task<List<ClienteEntity>> ObterTodosCliente()
        {
            var clientes = await _context.Cliente
                .Include(e => e.PlanoCliente)
                .ThenInclude(e => e.Plano)
            //    .Select(a => new ClienteEntity
            //{
            //    Nome = a.Nome,
            //    Planos = a.PlanoCliente.Select(a => a.Plano).ToListA()
            //})
            .ToListAsync();
            return clientes;
        }
    }
}
