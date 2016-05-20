using System;
using System.Threading.Tasks;
using SpineX.DomainModel;

namespace SpineX.BusinessLogic.Interface
{
    public interface IActivityLogBusinessLogic : IGenericBusinessLogic, IDisposable
    {
        Task AddAsync(ActivityLog model);
        void Add(ActivityLog model);
    }
}