using System;
using Microsoft.Practices.Unity;

namespace Fly.Core
{
    public static class ServiceContainer
    {
        public static UnityContainer _container;
        
        public static void Initialize()
        {
            if (_container == null)
                _container = new UnityContainer();
        }

        public static T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public static object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public static void RegisterInstance<T>(T instance)
        {
            _container.RegisterInstance(instance);
        }

        public static void RegisterType<TInt, TIml>() where TIml : TInt
        {
            _container.RegisterType<TInt, TIml>(new ContainerControlledLifetimeManager());
        }
    }
}
