using System;

namespace Gemini.CommandLine2
{
    public class Command
    {
        public static Command FromArguments(params string[] args)
        {
            return new Command(args);
        }

        public IServiceFactory ServiceFactory { get; set; } = new DefaultServiceFactory();
        private string[] _args;

        private Command(string[] args)
        {
            _args = args;
        }

        public void Run(params Type[] types)
        {
        }
    }
}
