using System.Collections.Generic;
using Microsoft.Practices.Unity;

namespace SpineX.IoC
{
    public class Resolver
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

        public static T Resolve<T>(params object[] parameters)
        {
            return  _UnityContainer.Resolve<T>(new OrderedParametersOverride(parameters));
        }

        public static IEnumerable<T> ResolveAll<T>()
        {
            return _UnityContainer.ResolveAll<T>();
        }
    }
}
