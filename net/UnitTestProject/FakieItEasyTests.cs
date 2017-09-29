using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SampleApp;
using FakeItEasy;

namespace UnitTestProject
{
    [TestClass]
    public class FakieItEasyTests
    {
        [TestMethod]
        public void TestWithoutInterfaceDependency()
        { 
            //Type Mock Isolator
            var fake = A.Fake<DependencyWithoutInterface>();
           // A.CallTo(() => fake.Info(A<string>.Ignored)).Returns("Empty");
            var sut = new SampleImplWithDependency(fake);
            var result = sut.TestDependencyWithoutInterface();
            Assert.AreEqual(result, "Empty");
        }
    }
}
