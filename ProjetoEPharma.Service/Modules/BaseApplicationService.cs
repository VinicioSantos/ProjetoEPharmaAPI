using ProjetoEPharma.Infrastructure.EntityFramework.Interface;

namespace ProjetoEPharma.Service.Modules
{
    public abstract class BaseApplicationService<TUnitOfWork>
        where TUnitOfWork : IUnitOfWork
    {
        protected TUnitOfWork _uow;

        public BaseApplicationService(TUnitOfWork uow)
        {
            _uow = uow;
        }
    }
}
