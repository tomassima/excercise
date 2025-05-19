namespace TDDExcerciseSession4
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            string name = new ExecutionParser().Execute("sdfdfsf");

            Assert.NotNull(name);
        }
    }

    public class ExecutionParser
    {
        public string Execute(string sdfdfsf)
        {
            return sdfdfsf;
        }
    }
}