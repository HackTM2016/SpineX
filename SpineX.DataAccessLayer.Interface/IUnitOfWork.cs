using System;

namespace SpineX.DataAccessLayer.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        T GetRepository<T>() where T : class;
        void Commit();
        void CommitAsync();
        void Rollback();
    }
}