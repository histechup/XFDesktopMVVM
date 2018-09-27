using System;
using Autofac;
using XFDesktopMVVM.Services.NavigationService;
using XFDesktopMVVM.Services.PostDataService;

namespace XFDesktopMVVM.ViewModels.Base
{
    public class Locator
    {
        private IContainer _container;
        private ContainerBuilder _containerBuilder;

        private static readonly Locator _instance = new Locator();
        public static Locator Instance => _instance;

        public Locator()
        {
            _containerBuilder = new ContainerBuilder();

            _containerBuilder.RegisterType<NavigationService>().As<INavigationService>();

            _containerBuilder.RegisterType<PostDataService>().As<IPostDataService>();

            _containerBuilder.RegisterType<MainViewModel>().SingleInstance();
            _containerBuilder.RegisterType<PostDetailViewModel>();


        }

        public T Resolve<T>()
        {
            return _container.Resolve<T>();
        }

        public object Resolve(Type type)
        {
            return _container.Resolve(type);
        }

        public void Register<TInterface, TImplementation>() where TImplementation : TInterface
        {
            _containerBuilder.RegisterType<TImplementation>().As<TInterface>();
        }

        public void Register<T>() where T : class
        {
            _containerBuilder.RegisterType<T>();
        }

        public void Build()
        {
            _container = _containerBuilder.Build();
        }

    }
}
