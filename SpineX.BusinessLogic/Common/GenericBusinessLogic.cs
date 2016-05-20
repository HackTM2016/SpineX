using System;
using SpineX.BusinessLogic.Interface;
using SpineX.BusinessLogic.Interface.Unity;
using SpineX.DataAccessLayer.Interface;

namespace SpineX.BusinessLogic.Common
{
    public class GenericBusinessLogic : IGenericBusinessLogic, IDisposable
    {
        public IUnitOfWork UnitOfWork => Bootstrap.Resolve<IUnitOfWork>();

        public void SaveChanges()
        {
            UnitOfWork.Commit();
        }

        public void SaveChangesAsync()
        {
            UnitOfWork.CommitAsync();
        }

        public void Dispose()
        {
            UnitOfWork.Dispose();
        }
    }
}