using System;

namespace Gemini.CommandLine2
{
    public class DefaultServiceFactory : IServiceFactory
    {
        public object Create(Type type)
        {
            return Activator.CreateInstance(type);
        }
    }
}