using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Biz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz.Tests
{
    [TestClass()]
    public class VendorRepositoryTests
    {
        [TestMethod()]
        public void RetriveValueTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = 42;
            var expected = value;

            // Act
            var actual = repository.RetriveValue<int>("SELECT ...", value);

            // Assert
            Assert.Equals(expected, actual);
        }
    }
}