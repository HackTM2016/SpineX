using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace SpineX.DataAccessLayer.Interface.Unity
{
    public class Bootstrap
    {
        private static IUnityContainer _UnityContainer { get; set; }
        public static void RegisterTypes(IUnityContainer container)
        {
            _UnityContainer = container;
        }
        public static T Resolve<T>()
        {
            return _UnityContainer.Resolve<T>();
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return _UnityContainer.ResolveAll<T>();
        }
    }
}
