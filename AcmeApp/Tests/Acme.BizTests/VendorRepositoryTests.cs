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
        public void RetriveValueIntegerTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = 42;
            var expected = value;

            // Act
            var actual = repository.RetriveValue<int>("SELECT ...", value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetriveValueBoolTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = true;
            var expected = value;

            // Act
            var actual = repository.RetriveValue<bool>("SELECT ...", value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetriveValueDoubleTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = 42.42;
            var expected = value;

            // Act
            var actual = repository.RetriveValue<double>("SELECT ...", value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetriveValueDateTimeTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = DateTime.Now;
            var expected = value;

            // Act
            var actual = repository.RetriveValue<DateTime>("SELECT ...", value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RetriveValueStringTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var value = "test";
            var expected = value;

            // Act
            var actual = repository.RetriveValue("SELECT ...", value);

            // Assert
            Assert.AreEqual(expected, actual);
        }

        /*
        [TestMethod()]
        public void RetriveValueObjectTest()
        {
            // Arrange
            var repository = new VendorRepository();
            var vendor = new Vendor();
            var expected = vendor;

            // Act
            var actual = repository.RetriveValue<Vendor>("SELECT ...", vendor);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        */

        //End of Class
    }
}