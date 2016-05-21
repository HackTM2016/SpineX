using System;
using System.Data.Entity;
using System.Diagnostics;
using System.Linq;
using SpineX.DataAccessLayer.Interface;
using SpineX.IoC;

namespace SpineX.DataAccessLayer
{
    public class UnitOfWork : IUnitOfWork
    {

        private readonly DbContext _context;

        public UnitOfWork() : this(new SpinexEntities()) { }

        public UnitOfWork(DbContext context)
        {
            _context = context;
        }

        public T GetRepository<T>() where T : class
        {
            try
            {
                return Resolver.Resolve<T>(_context);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Cannot resolve the interface with name:({typeof (T).FullName}). Exception message:({ex})");
                return null;
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async void CommitAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void Rollback()
        {
            _context
                .ChangeTracker
                .Entries()
                .ToList()
                .ForEach(x => x.Reload());
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
