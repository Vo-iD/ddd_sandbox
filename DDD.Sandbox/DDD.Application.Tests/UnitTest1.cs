using System;
using Xunit;

namespace DDD.Application.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void SuccessTest()
        {
            Console.WriteLine("From Success test");
        }

        [Fact]
        public void FailedTest()
        {
            Console.WriteLine("From failed test");
            throw new Exception("some outer exception", new Exception("inner"));
        }
    }
}