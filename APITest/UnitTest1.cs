using System;
using Xunit;
using MyAPI.Controllers;
namespace APITest
{
    public class UnitTest1
    {
        ValuesController valuesController = new ValuesController();
        [Fact]
        public void TestHai()
        {
           
            string actual = valuesController.GetResponse("hai");
            Assert.Equal("hello",actual);
        }

        [Fact]
        public void TestHello()
        {

            string actual = valuesController.GetResponse("hello");
            Assert.Equal("hai", actual);
        }
    }
}
