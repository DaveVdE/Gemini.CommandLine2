using System;

namespace Gemini.CommandLine2
{
    public interface IServiceFactory
    {
        object Create(Type type);
    }
}