using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment5
{
    /// <summary>
    /// Class defining a list of customers and performing operations on the list like adding, editing, removing etc. customers.
    /// </summary>
    internal class CustomerManager
    {

        private List<Customer> customers; //array of Customer objects

        //private Contact customer;

        ///<summary>
        /// Deafult constructor
        /// </summary>
        public CustomerManager()
        {
            customers = new List<Customer>();
        }

        ///<summary>
        ///Constructor
        ///</summary>
        public CustomerManager(List<Customer> customers)
        {
            this.customers = customers;
        }

        ///<summary>
        ///Property giving access to customers arrray.
        ///</summary>
        public List<Customer> GetAllCustomers()
        {
            return customers;
        }

        /// <summary>
        /// Get costumer on an index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Customer GetCustomer(int index)
        {
            if (!CheckIndex(index)) //if out of bounds
            {

                throw new IndexOutOfRangeException(); //throw out of bounds error

            }
            else
            {

                return customers[index]; //otherwise return customer on an index

            }

        }

        /// <summary>
        /// Delete a customer on a certain index
        /// </summary>
        /// <param name="index"></param>
        public void DeleteCustomer(int index)
        {
            if (CheckIndex(index)) //if not out of bounds
            {

                customers.RemoveAt(index); //delete the customer on an index

            }

        }

        /// <summary>
        /// Check whether index exists = is between 0 - customers count (not out of bounds)
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        private bool CheckIndex(int index)
        {
            bool ok = false;

            if ((index >= 0) && (index < customers.Count)) //if customer index between 0 (inclusive) and current number of customers
            {

                ok = true; // ok true

            }

            return ok; //return value of ok

        }


        /// <summary>
        /// Replace old customer object on a certain index with a new customer object
        /// </summary>
        /// <param name="customer"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Contact customer, int index)
        {
            //validate index
            if (CheckIndex(index))
            {

                customers.RemoveAt(index); //remove the customer on specific index
                Customer newCustomer = new Customer(customer); //create a new customer object with the data obtained taken as a parameter
                customers.Insert(index, newCustomer); //insert a new customer on that specific index

            }

        }

        /// <summary>
        /// Get address info of a customer on a certain index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetAddressInfo(int index)
        {
            if (CheckIndex(index))
            {
                Customer selectedCustomer = customers[index];
                string selectedCustomerStreet = selectedCustomer.Contact.AddressData.Street.ToString();
                string selectedCustomerCityAndZipCode = selectedCustomer.Contact.AddressData.City.ToString() + " " + selectedCustomer.Contact.AddressData.ZipCode.ToString();
                string selectedCustomerCountryInfo = selectedCustomer.Contact.AddressData.Country.ToString().Replace("_", " "); //make sure to replace underscores with whitespaces
                //concatenation for easier line break
                string selectedCustomerAddressInfo = $"{selectedCustomerStreet} \n{selectedCustomerCityAndZipCode} \n{selectedCustomerCountryInfo}";
                return selectedCustomerAddressInfo;
            }
            else
            {
                return string.Empty;

            }

        }

        /// <summary>
        /// Get email info of a customer on a certain index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetEmailInfo(int index)
        {
            if (CheckIndex(index))
            {
                Customer selectedCustomer = customers[index];
                string selectedCustomerPrivateEmail = selectedCustomer.Contact.EmailData.PrivateEmail.ToString();
                string selectedCustomerBusinessEmail = selectedCustomer.Contact.EmailData.BusinessEmail.ToString();
                //concatenation for easier line break
                string selectedCustomerPhoneInfo = $"Private: {selectedCustomerPrivateEmail} \n Business: {selectedCustomerBusinessEmail}";
                return selectedCustomerPhoneInfo;

            }
            else
            {

                return string.Empty;

            }

        }


        /// <summary>
        /// Get phone info of a customer on a selected index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string GetPhonesInfo(int index)
        {
            if (CheckIndex(index))
            {
                Customer selectedCustomer = customers[index];
                string selectedCustomerHomePhone = selectedCustomer.Contact.PhoneData.HomePhone.ToString();
                string selectedCustomerOfficePhone = selectedCustomer.Contact.PhoneData.OfficePhone.ToString();
                //concatenation for easier line break
                string selectedCustomerPhoneInfo = $"Private: {selectedCustomerHomePhone} \n Business: {selectedCustomerOfficePhone}";
                return selectedCustomerPhoneInfo;

            }
            else
            {

                return string.Empty;

            }

        }

    }

}
