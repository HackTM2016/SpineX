using System.Data.Entity;
using System.Threading.Tasks;
using SpineX.DataAccessLayer.Common;
using SpineX.DataAccessLayer.Interface.Repositories;
using SpineX.DomainModel;

namespace SpineX.DataAccessLayer.Repositories
{
    public class ActivityLogRepository : GenericRepository<ActivityLog>, IActivityLogRepository
    {
        public ActivityLogRepository(DbContext context) : base(context)
        {

        }

        public new async Task AddAsync(ActivityLog model)
        {
            await base.AddAsync(model);
        }

        public new void Add(ActivityLog model)
        {
            base.Add(model);
        }
    }
}
