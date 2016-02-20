namespace Gemini.CommandLine2.Tests
{
    /// <summary>
    /// Contains commands to use with testing.
    /// </summary>
    public class TestCommands
    {
        public static bool CommandWithNoArgumentsRan { get; set; }
       
        /// <summary>
        /// Performs a test of a command that requires no arguments.
        /// </summary>
        public void CommandWithNoArguments()
        {
            CommandWithNoArgumentsRan = true;
        }
    }
}
