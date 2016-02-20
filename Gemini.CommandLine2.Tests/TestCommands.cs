namespace Gemini.CommandLine2.Tests
{
    public class TestCommands
    {
        public static bool CommandWithNoArgumentsRan { get; set; }

        public void CommandWithNoArguments()
        {
            CommandWithNoArgumentsRan = true;
        }
    }
}
