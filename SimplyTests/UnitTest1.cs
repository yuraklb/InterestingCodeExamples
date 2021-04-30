using System;
using NUnit.Framework;

namespace SimplyTests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            Console.WriteLine("OneTimeSetUp");

        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            Console.WriteLine("OneTimeTearDown");
        }

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [TearDown]
        public void TearDown()
        {
            Console.WriteLine("TearDown");
        }

        [Test]
        public void Test1()
        {
            //arrange

            //act

            //assert
            Assert.Pass();
        }
        
        [Test]
        public void Test2()
        {
            //arrange

            //act

            //assert
            Assert.Pass();
        }
    }
}