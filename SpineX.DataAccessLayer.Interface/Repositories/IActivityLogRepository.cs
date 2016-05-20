using System.Threading.Tasks;
using SpineX.DomainModel;

namespace SpineX.DataAccessLayer.Interface.Repositories
{
    public interface IActivityLogRepository
    {
        Task AddAsync(ActivityLog model);
        void Add(ActivityLog model);
    }
}