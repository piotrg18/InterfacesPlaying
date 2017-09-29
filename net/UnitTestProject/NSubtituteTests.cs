using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using SampleApp;

namespace UnitTestProject
{
    [TestClass]
    public class NSubtituteTests
    {
        [TestMethod]
        public void TestWithoutInterface()
        {
            var fake = Substitute.For<DependencyWithoutInterface>();
            fake.Info(Arg.Any<string>()).Returns("Empty");
            var sut = new SampleImplWithDependency(fake);
            var result = sut.TestDependencyWithoutInterface();
            Assert.IsNull(result);
        }

        [TestMethod]
        public void TestWithInterface()
        {
            var fake = Substitute.For<IDependency>();
            fake.Info(Arg.Any<string>()).Returns("Empty");
            var sut = new SampleImplWithDependency(fake);
            var result = sut.TestIterfaceDependency();
            Assert.AreEqual(result, "Empty");
        }
    }
}
