using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;


namespace Assignment5
{
    /// <summary>
    /// Starting object to provide an interface for inputting and displaying information related to customers
    /// </summary>
    public partial class MainForm : Form
    {
        private CustomerManager customerManager; //instance of Costumer Manager

        private List<Customer> customers; //instance of list of costumers


        /// <summary>
        /// Constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            customers = new List<Customer>();

        }

        /// <summary>
        /// Update listbox GUI based on current content of customer manager object - current list of customers
        /// </summary>
        private void UpdateGUI()
        {
            //refresh
            lstCustomers.Items.Clear();

            //loop through the customers list and add them to respective columns in the listbox
            foreach (Customer iteratedCustomer in customerManager.GetAllCustomers())
            {
                //validate
                if (iteratedCustomer != null)
                {
                    //get the values and format
                    string id = iteratedCustomer.Contact.CustomerId.PadRight(7);
                    string name = string.Format("{0} {1}", iteratedCustomer.Contact.LastName, iteratedCustomer.Contact.FirstName).PadRight(20);
                    string phone = iteratedCustomer.Contact.PhoneData.OfficePhone.PadRight(15);
                    string email = iteratedCustomer.Contact.EmailData.BusinessEmail;
                    string displayString = string.Format("{0} {1} {2} {3}", id, name, phone, email); //display in columns so the text is aligned vertically
                    //add to listbox to display on GUI
                    lstCustomers.Items.Add(displayString);
                }

            }
        }

        /// <summary>
        /// Display a contact form on "Add" click and when finished save the obtained data and display certain items in the listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //create new instance of contact form
            ContactForm contactForm = new ContactForm();
            //display and wait for the result
            DialogResult contactFormResult = contactForm.ShowDialog();

            //if received result is OK
            if (contactFormResult == DialogResult.OK)
            {
                //extract the contact info from the contact form and make a copy
                Contact contact = new Contact(contactForm.ContactData);
                //create a new customer isntance and pass the info as a parameter
                Customer customer = new Customer(contact);
                //add customer to list of customers
                customers.Add(customer);
                //create a new instance of customer manager and pass the customer list
                customerManager = new CustomerManager(customers);
                //update listbox
                UpdateGUI();


            }
        }

        /// <summary>
        /// Display all available info of the selected customer on the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            //validate listbox content
            if (lstCustomers.SelectedItems.Count > 0)
            {
                //validate index
                if (lstCustomers.SelectedIndex != -1)
                {
                    int selectedCustomerIndex = (int)lstCustomers.SelectedIndex; //get the index of the selected customer
                    Customer selectedCustomer = customerManager.GetCustomer(selectedCustomerIndex); //get the costumer on selected index for name and surname info

                    //add desired customer info and save into a variable
                    string customerInfo = selectedCustomer.Contact.FirstName + selectedCustomer.Contact.LastName; //retrieve name and surname fields from contact
                    customerInfo += Environment.NewLine; //break
                    //retrieve address, email and phone information from the objects by calling customer manager methods on selected customer 
                    //used concatenation to add line breaks easily
                    customerInfo += $"{customerManager.GetAddressInfo(selectedCustomerIndex)} \n\n Emails: \n {customerManager.GetEmailInfo(selectedCustomerIndex)} \n\n Phone numbers:\n {customerManager.GetPhonesInfo(selectedCustomerIndex)}";
                    //display on GUI
                    lblCostumerInfo.Text = customerInfo;

                }
            }
        }

        /// <summary>
        /// Delete selected customer, update listbox and clear customer info from the GUI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selectedCustomerIndex = (int)lstCustomers.SelectedIndex; //get the index of the selected customer

            //validate index
            if (selectedCustomerIndex != -1)
            {
                customerManager.DeleteCustomer(selectedCustomerIndex); //delete the costumer on selected index
                UpdateGUI(); //update listbox
                lblCostumerInfo.Text = string.Empty; //clear the customer info GUI
            }

        }

        /// <summary>
        /// Display a contact form filled with the original info to be edited
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            //0.set a title for the new form and pass it as a parameter to constructor
            string formTitle = "Edit customer";
            //1.get the selected customer index
            int selectedCustomerIndex = (int)lstCustomers.SelectedIndex;

            if (selectedCustomerIndex != -1)
            {
                //2.get the costumer on selected index
                Customer selectedCustomer = customerManager.GetCustomer(selectedCustomerIndex);

                //3.create a new instance of Contact and copy in selected customer to be used for editing
                Contact contactCopy = new Contact(selectedCustomer.Contact);

                //4.instantiate a new contact form and pass title and copy of contact object as parameters
                ContactForm contactForm = new ContactForm(formTitle, contactCopy);

                //5.show the contactForm as a dialog and get the result
                DialogResult contactFormResult = contactForm.ShowDialog();

                //4.replace the old information with the collected new information (if OK)
                if (contactFormResult == DialogResult.OK)
                {
                    //extract the contact info from the contact form
                    //make a COPY of the object to make sure info is preserved and changed after confirmation
                    Contact editedContact = contactForm.ContactData;
                    //replace on the index with new info 
                    customerManager.ChangeCustomer(editedContact, selectedCustomerIndex);
                    //clear the customer info label from the old info
                    lblCostumerInfo.Text = string.Empty;
                    //update listbox
                    UpdateGUI();

                }
                else if (contactFormResult == DialogResult.Cancel)
                {
                    //do nothing and close the form
                    contactForm.Close();

                }
            }
        }

    }
}
