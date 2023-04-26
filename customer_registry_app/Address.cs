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
    /// Class defining address object with fields like street, city, zip code and country.
    /// </summary>
    internal class Address
    {
        private string street;
        private string city;
        private string zipCode;
        private Countries country;

        ///<summary>
        /// Default constructor
        /// </summary>
        public Address()
        {

        }
        ///<summary>
        ///Constructor accepting minimum number of 2 parameters (city and country which are obligatory) chaincalling the constructor accepting 4 parameters (unobligatory set to default).
        ///</summary>
        public Address(string city, Countries country) : this(string.Empty, city, string.Empty, country)
        {

        }

        /// <summary>
        /// Constructor accepting 3 parameters chaincalling the constructor accepting the maximum of 4 parameters.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string city, Countries country) : this(street, city, string.Empty, country)
        {

        }

        ///<summmary>
        ///Constructor accepting maximum number of parameters 4 - street, city, zipCode, country.
        ///</summary>
        public Address(string street, string city, string zipCode, Countries country)
        {
            this.street = street;
            this.city = city;
            this.zipCode = zipCode;
            this.country = country;

        }


        ///<summary>
        ///Property giving read and write access to street variable.
        ///</summary>
        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }

        ///<summary>
        ///Property giving read and write access to city variable.
        ///</summary>
        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        ///<summary>
        ///Property giving read and write access to country variable.
        ///</summary>
        public Countries Country
        {
            get
            {
                return country;
            }
            set
            {
                country = value;
            }
        }


        ///<summary>
        ///Property giving read and write access to zipcode variable.
        ///</summary>
        public string ZipCode
        {
            get
            {
                return zipCode;
            }
            set
            {
                zipCode = value;
            }
        }


    }
}
