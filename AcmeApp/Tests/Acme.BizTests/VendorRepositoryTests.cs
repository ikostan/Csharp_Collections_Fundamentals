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

        [TestMethod()]
        public void RetrieveTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                new Vendor(8, "XYZ Inc", "xyz@xyz.com"),
                new Vendor(5, "ABC Corp", "abc@abc.com")
            };

            //Act
            var actual = repository.Retrieve();

            //Assert
            Assert.AreEqual(expected.Count, actual.ToList().Count); //Test ammount
            CollectionAssert.AreEqual(expected, actual.ToList());    //Test collection
        }

        [TestMethod()]
        public void RetrieveWithIteratorTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new List<Vendor>()
            {
                new Vendor(8, "XYZ Inc", "xyz@xyz.com"),
                new Vendor(5, "ABC Corp", "abc@abc.com")
            };

            //Act
            var actualRepository = repository.RetrieveWithIterator();
            foreach (var v in actualRepository)
            {
                Console.WriteLine(v);
            }

            var actual = actualRepository.ToList();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count);
            CollectionAssert.AreEqual(expected, actual);
        }

        //
        [TestMethod()]
        public void RetrieveAllTest()
        {
            //Arrange
            var vendorsRepository = new VendorRepository();

            var expected = new List<Vendor>()
            {
                    new Vendor(1, "Toys Inc", "toys@xyz.com"),
                    new Vendor(2, "Funny Toys Inc", "funnytoys@xyz.com"),
                    new Vendor(3, "Toys R Us Inc", "toysrus@xyz.com"),
                    new Vendor(4, "AAA Toys", "aaatoys@xyz.com")
            };

            //Act
            var vendors = vendorsRepository.RetrieveAll();

            //Syntax quaery
            var vendorsQuaery = from item in vendors
                                where item.CompanyName.ToLower().Contains("toys")
                                //orderby item.CompanyName
                                select item;

            //Method quaery
            /*
            var vendorsQuaery = vendors.Where(
                                (i) => i.CompanyName.ToLower().Contains("toys")).ToList();

            //Assert
            Assert.AreEqual(expected.Count, vendorsQuaery.Count());
            CollectionAssert.AreEqual(expected, vendorsQuaery.ToList());
        }

        /*
        [TestMethod()]
        public void RetrieveWithKeysTest()
        {
            //Arrange
            var repository = new VendorRepository();
            var expected = new Dictionary<string, Vendor>()
            {
                { "XYZ Inc", new Vendor(8, "XYZ Inc", "xyz@xyz.com") },
                { "ABC Corp",new Vendor(5, "ABC Corp", "abc@abc.com") }
            };

            //Act
            var actual = repository.RetrieveWithKeys();

            //Assert
            Assert.AreEqual(expected.Count, actual.Count); //Test ammount
            CollectionAssert.AreEqual(expected, actual);   //Test collection
        }
        */

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