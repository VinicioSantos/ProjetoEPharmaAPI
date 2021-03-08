using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using System.Collections.Generic;

namespace ProjetoEPharma.Infrastructure.Repository.Interfaces
{
    public interface IPlanoClienteRepository : IRepository<PlanoClienteEntity>
    {
        void SalvarPlanosClientes(int idCliente, List<int> idsPlanos);
    }
}
