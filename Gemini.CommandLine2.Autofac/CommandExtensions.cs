using Autofac;

namespace Gemini.CommandLine2.Autofac
{
    public static class CommandExtensions
    {
        public static Command UseAutofac(this Command command, IContainer container)
        {
            command.ServiceFactory = new AutofacServiceFactory(container);

            return command;
        }
    }
}
