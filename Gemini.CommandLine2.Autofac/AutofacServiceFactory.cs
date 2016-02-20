using System;
using Autofac;

namespace Gemini.CommandLine2.Autofac
{
    public class AutofacServiceFactory : IServiceFactory
    {
        private readonly IContainer _container;

        public AutofacServiceFactory(IContainer container)
        {
            _container = container;
        }

        public object Create(Type type)
        {
            return _container.Resolve(type);
        }
    }
}