using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.Repository.Interfaces
{
    public interface IClienteRepository : IRepository<ClienteEntity>
    {
        Task<List<ClienteEntity>> ObterTodosCliente();
    }
}
