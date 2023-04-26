using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    /// <summary>
    /// Class defining phone object with fields like office phone and home phone.
    /// </summary>
    internal class Phone
    {
        private string officePhone;
        private string homePhone;

      
        /// <summary>
        /// Constructor that takes office phone and home phone variables as parameters
        /// </summary>
        /// <param name="officePhone"></param>
        /// <param name="homePhone"></param>
        public Phone()
        {
            OfficePhone = officePhone;
            HomePhone = homePhone;
        }

        /// <summary>
        /// Property giving read and write access to the variable home phone.
        /// </summary>
        public string HomePhone {
            get 
            { 
                return homePhone; 
            } 
            set 
            { 
                homePhone = value; 
            }
        }

        /// <summary>
        /// Property giving read and write access to the variable office phone.
        /// </summary>
        public string OfficePhone 
        { 
            get 
            {
                return officePhone; 
            }
            set
            {
                officePhone = value;
            }
        }

    }
}
