using ProjetoEPharma.Infrastructure.EntityFramework;
using ProjetoEPharma.Infrastructure.EntityFramework.Interface;
using ProjetoEPharma.Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoEPharma.Infrastructure.UnitOfWork.Interfaces
{
    public interface IClienteUnitOfWork : IUnitOfWork
    {
        IClienteRepository ClienteRepository { get; }
        IPlanoRepository PlanoRepository { get; }
        IPlanoClienteRepository PlanoClienteRepository { get; }

    }
}
