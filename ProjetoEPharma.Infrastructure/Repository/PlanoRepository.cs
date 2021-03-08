using Microsoft.EntityFrameworkCore;
using ProjetoEPharma.Domain.Entities;
using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.Model;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoEPharma.Infrastructure.Repository
{
    public class PlanoRepository : GenericRepository<PlanoEntity, CommonModel>, IPlanoRepository
    {
        public PlanoRepository(CommonModel context) : base(context)
        {
        }

        public List<PlanoEntity> ObterPlanosPorIds(List<int> ids)
        {
            return _context.Plano.Where(x => ids.Contains(x.Id)).ToList();
        }
    }
}
