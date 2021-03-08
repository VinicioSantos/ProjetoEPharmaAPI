using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.Model;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Infrastructure.Repository
{
    public class PlanoClienteRepository : GenericRepository<PlanoClienteEntity, CommonModel>, IPlanoClienteRepository
    {
        public PlanoClienteRepository(CommonModel context) : base(context)
        {
        }

        public void SalvarPlanosClientes(int idCliente, List<int> idsPlanos)
        {
            var planos = new List<PlanoClienteEntity>();
            
            foreach(int id in idsPlanos)
            {
                planos.Add(new PlanoClienteEntity
                {
                    IdCliente = idCliente,
                    IdPlano = id,
                    
                });
            }

            _context.PlanoCliente.AddRange(planos);
        }
    }
}
