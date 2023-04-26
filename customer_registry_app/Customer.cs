using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class defining costumer object having contact as it's field.
    /// </summary>
    internal class Customer
    {

        private Contact contact; //create instance of Contact

        ///<summary>
        /// Constructor taking instance of contact class as a parameter
        ///</summary>
        public Customer(Contact contact)
        {
            Contact = contact;


        }

        ///<summary>
        ///Property to access Customer contact details
        public Contact Contact
        {
            get
            {
                return contact;
            }
            set
            {
                contact = value;
            }
        }

    }
}
