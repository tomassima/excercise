namespace TDDExcerciseSession4
{
    public class UnitTest1
    {
        [Fact]
        public void TestTopLevel()
        {
            string name = new ExecutionParser().Execute("sdfdfsf");

            Assert.NotNull(name);
        }
    }

    public class ExecutionParser
    {
        public string Execute(string input)
        {
            return input;
        }
    }
}