using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class defining a contact object with first name, last name, customer ID and having class Phone, Email, Address as its other fields and containing also some helper methods related to contact object
    /// </summary>
    internal class Contact
    {
        //instance variables
        private string firstName;
        private string lastName;

        private string customerId;

        private Phone phone;
        private Email email;
        private Address address;


        /// <summary>
        /// Default constructor
        /// </summary>
        public Contact()
        {

            InitialiseGUI();

        }

        /// <summary>
        /// Copy constructor returning a copy
        /// </summary>
        /// <param name="theOther"></param>
        public Contact(Contact theOther)
        {
            this.customerId = theOther.customerId;
            this.firstName = theOther.firstName;
            this.lastName = theOther.lastName;
            this.phone = theOther.phone;
            this.email = theOther.email;
            this.address = theOther.address;
        }

        /// <summary>
        /// Constructor taking contact info as parameters
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        /// <param name="address"></param>
        public Contact(string customerId, string firstName, string lastName, Phone phone, Email email, Address address)
        {
            this.customerId = customerId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.phone = phone;
            this.email = email;
            this.address = address;

        }

        /// <summary>
        /// Set defaults for contact form GUI
        /// </summary>
        private void InitialiseGUI()
        {
            customerId = GenerateIdToString(); //assign ID
        }


        /// <summary>
        /// Property giving read access to customer ID variable
        /// </summary>
        public string CustomerId
        {
            get
            {
                return customerId;
            }
        }

        /// <summary>
        /// Property giving read and write access into the first name variable.
        /// </summary>
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        /// <summary>
        /// Property giving read and write access into the last name variable.
        /// </summary>
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                lastName = value;
            }
        }

        /// <summary>
        /// Property giving read and write access into the variable phone.
        /// </summary>
        public Phone PhoneData
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

        /// <summary>
        /// Property giving read and write access into the varibel email.
        /// </summary>
        public Email EmailData
        {
            get
            {
                return email;
            }
            set
            {
                email = value;
            }
        }

        /// <summary>
        /// Property giving read and write access into the variable address.
        /// </summary>
        public Address AddressData
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        /// <summary>
        /// Replace underscores in the country names with whitespaces to achieve more human readable format
        /// </summary>
        /// <param name="country"></param>
        /// <returns></returns>
        public string GetCountryName(Countries country)
        {
            string countryName = country.ToString();
            return countryName.Replace("_", " ");
        }

        /// <summary>
        /// Generate a random ID - integer from 100 to 999 and convert to string
        /// </summary>
        /// <returns></returns>
        private string GenerateIdToString()
        {
            Random random = new Random();
            int customerId = random.Next(100, 1000);
            string customerIdToString = customerId.ToString();
            return customerIdToString;
        }

        /// <summary>
        /// Check whether obligatory fields not empty or null 
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            //check if obligatory fields like first name or last name and city and country are present 
            if ((!string.IsNullOrEmpty(FirstName) || !string.IsNullOrEmpty(LastName)) && !string.IsNullOrEmpty(AddressData.City) && !AddressData.Country.Equals(Countries.Select_a_country))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
