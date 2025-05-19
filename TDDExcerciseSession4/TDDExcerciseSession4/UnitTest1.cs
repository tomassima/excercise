using System.Text.RegularExpressions;

namespace TDDExcerciseSession4
{
    public class UnitTest1
    {
        [Fact]
        public void TestTopLevel()
        {
            string actual = new ExecutionParser().Execute("{NUMBEROFOCCURRENCES[Mississippi][ss]}");

            Assert.Equal("2", actual);
        }

    }

    public class BussinessBox
    {
        public int Count(string input, string pattern)
        {
            return Regex.Matches(input, pattern).Count;
        }
    }

    public class ExecutionParser
    {
        public string Execute(string input)
        {
            //parsing box gets gets tokens
            //business box returns count uses parameters from parsing box
            //return Regex count 
            return new BussinessBox().Count("Mississippi", "ss").ToString();
        }
    }
}