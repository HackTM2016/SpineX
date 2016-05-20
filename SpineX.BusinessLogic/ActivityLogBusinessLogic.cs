using System.Threading.Tasks;
using SpineX.BusinessLogic.Common;
using SpineX.BusinessLogic.Interface;
using SpineX.DataAccessLayer.Interface.Repositories;
using SpineX.DomainModel;

namespace SpineX.BusinessLogic
{
    public class ActivityLogBusinessLogic : GenericBusinessLogic, IActivityLogBusinessLogic
    {
        private IActivityLogRepository _activityLogRepository;

        public IActivityLogRepository ActivityLogRepository =>
            _activityLogRepository ?? (_activityLogRepository = UnitOfWork.GetRepository<IActivityLogRepository>());

        public ActivityLogBusinessLogic()
        {

        }

        public async Task AddAsync(ActivityLog model)
        {
            await ActivityLogRepository.AddAsync(model);
        }

        public void Add(ActivityLog model)
        {
            ActivityLogRepository.Add(model);
        }
    }
}
