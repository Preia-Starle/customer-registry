using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class defining email object with fields like private email and business email.
    /// </summary>
    internal class Email
    {
        //instance variables
        private string privateEmail;
        private string businessEmail;

        /// <summary>
        /// Default constructor.
        /// </summary>
        public Email()
        {

        }

        /// <summary>
        /// Constructor with one parameter calling the constructor with two parameters (default value as the second argument).
        /// </summary>
        /// <param name="businessEmail"></param>
        public Email(string businessEmail): this(businessEmail, string.Empty)
        {

        }

        /// <summary>
        /// Constructor taking private email and business email as its parameters.
        /// </summary>
        /// <param name="privateEmail"></param>
        /// <param name="businessEmail"></param>
        public Email(string privateEmail, string businessEmail)
        {
            PrivateEmail = privateEmail;
            BusinessEmail = businessEmail;
        }

        /// <summary>
        /// Property giving read and write access to variable private email.
        /// </summary>
        public string PrivateEmail
        {
            get
            {
                return privateEmail;
            }
            set
            {
                privateEmail = value;
            }
        }

        /// <summary>
        /// Property giving read and write access to variable business email.
        /// </summary>
        public string BusinessEmail
        {
            get
            {
                return businessEmail;
            }
            set
            {
                businessEmail = value;
            }
        }
    }
}
