using NUnit.Framework;

namespace Gemini.CommandLine2.Tests
{
    [TestFixture]
    public class CommandTests
    {
        [Test]
        public void CanCreateCommandFromArgs()
        {
            var args = new[] {"CommandName", "13", "/option", "option-value"};

            var command = Command.FromArguments(args);

            Assert.IsNotNull(command);
        }

        [Test]
        public void CommandWithNoArgumentsCanRun()
        {
            var args = new[] {"CommandWithNoArguments"};

            var command = Command.FromArguments(args);

            Assert.IsNotNull(command);

            command.Run(typeof (TestCommands));

            Assert.IsTrue(TestCommands.CommandWithNoArgumentsRan);
        }
    }
}
