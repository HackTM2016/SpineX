using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace SpineX.DataAccessLayer.Interface.Common
{
    public interface IGenericRepository<TObject> where TObject : class
    {
        ICollection<TObject> GetAll();

        Task<ICollection<TObject>> GetAllAsync();

        TObject Get(int id);

        Task<TObject> GetAsync(int id);

        TObject Find(Expression<Func<TObject, bool>> match);

        Task<TObject> FindAsync(Expression<Func<TObject, bool>> match);

        ICollection<TObject> FindAll(Expression<Func<TObject, bool>> match);

        Task<ICollection<TObject>> FindAllAsync(Expression<Func<TObject, bool>> match);

        TObject Add(TObject t);

        Task<TObject> AddAsync(TObject t);

        TObject Update(TObject updated, int key);

        Task<TObject> UpdateAsync(TObject updated, int key);

        void Delete(TObject t);

        Task<int> DeleteAsync(TObject t);

        int Count();

        Task<int> CountAsync();

        void SaveChanges();

        void SaveChangesAsync();
    }
}
