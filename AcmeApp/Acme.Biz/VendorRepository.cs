using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acme.Biz
{
    public class VendorRepository
    {
        private List<Vendor> vendors;

        /// <summary>
        /// Retrieve one vendor.
        /// </summary>
        /// <param name="vendorId">Id of the vendor to retrieve.</param>
        public Vendor Retrieve(int vendorId)
        {
            // Create the instance of the Vendor class
            Vendor vendor = new Vendor();

            // Code that retrieves the defined customer

            // Temporary hard coded values to return 
            if (vendorId == 1)
            {
                vendor.VendorId = 1;
                vendor.CompanyName = "ABC Corp";
                vendor.Email = "abc@abc.com";
            }

            return vendor;
        }

        /// <summary>
        /// Retrieve all of the approved vendors.
        /// </summary>
        public List<Vendor> Retrieve()
        {
            if (this.vendors == null)
            {
                this.vendors = new List<Vendor>();
                vendors.Add(new Vendor(8, "XYZ Inc", "xyz@xyz.com"));
                vendors.Add(new Vendor(5, "ABC Corp", "abc@abc.com"));
            }

            return vendors;
        }

        //Method that accepts only VALUE types
        public T RetriveValue<T>(string sql, T defaulrvalue) where T : struct
        {
            // Call the DB to retrive the value
            // If no value is returned, return the default value
            T value = defaulrvalue;
            return value;
        }

        //Method that accepts only strings
        public string RetriveValue(string sql, string defaulrvalue) 
        {
            // Call the DB to retrive the value
            // If no value is returned, return the default value
            string value = defaulrvalue;
            return value;
        }

        /// <summary>
        /// Save data for one vendor.
        /// </summary>
        /// <param name="vendor">Instance of the vendor to save.</param>
        /// <returns></returns>
        public bool Save(Vendor vendor)
        {
            var success = true;

            // Code that saves the vendor

            return success;
        }

        //End of Class
    }
}
