using System;
using System.Collections.Generic;
using System.Text;

namespace InsideDictionaries
{
    class PrimeMinister
    {
        private string _firstName;
        private string _lastName;
        private int _yearElected;

        public PrimeMinister(string firstName, string lastName, int yearElected)
        {
            this._firstName = firstName;
            this._lastName = lastName;
            this._yearElected = yearElected;
        }

        public string FirstName { get => _firstName; set => _firstName = value; }

        public string LastName { get => _lastName; set => _lastName = value; }

        public int YearElected { get => _yearElected; set => _yearElected = value; }
        public string Initials {
            get {
                return string.Format("{0}{1}", 
                            char.ToUpper(_firstName[0]), 
                            char.ToUpper(_lastName[0]));
            }
        }

        public string FullName
        {
            get
            {
                return string.Format("{0} {1}",
                            _firstName,
                            _lastName);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}, elected: {2}",
                            _firstName,
                            _lastName,
                            _yearElected);
        }
    }
}
