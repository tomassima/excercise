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

        [Fact]
        public void TestReturnsNumber()
        {
            string name = new ExecutionParser().Execute("sdfdfsf");

            Assert.True(int.TryParse(name, out var _));
        }
    }

    public class ExecutionParser
    {
        public string Execute(string input)
        {
            return input.Length.ToString();
        }
    }
}