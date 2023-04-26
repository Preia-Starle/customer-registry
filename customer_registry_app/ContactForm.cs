using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Assignment5
{
    /// <summary>
    /// Class providing interface for inputing customer contact details
    /// </summary>
    internal partial class ContactForm : Form
    {
        private Contact contact = new Contact();


        /// <summary>
        /// Default constructor
        /// </summary>
        public ContactForm()
        {
            InitializeComponent();
            Text = "Add new customer";
            InitializeGUI();

        }

        ///<summary>
        /// Constructor taking as a parameter title and contact object (for editing purposes)
        /// </summary>
        /// <param name="title"></param>
        public ContactForm(string title, Contact contact)
        {
            InitializeComponent();
            Text = title;
            ContactData = new Contact(contact);
            InitializeGUI();
            UpdateGUI();

        }

        ///<summary>
        ///Set defaults for GUI
        ///</summary>
        private void InitializeGUI()
        {
            //initalise a list (empty array) for countries to save in a human readable form
            List<string> countryNames = new List<string>();

            //loop through the countries enum and call a method to replace any underscores with whitespaces in country names
            foreach (Countries iteratedCountry in Enum.GetValues(typeof(Countries)))
            {
                string countryName = contact.GetCountryName(iteratedCountry);

                countryNames.Add(countryName); //add the country name (modified or not based on result) to the list
            }

            cmbCountry.DataSource = countryNames; //set the list as a data source for the combo box

        }

        /// <summary>
        /// Populate GUI with the information to be edited
        /// </summary>
        private void UpdateGUI()
        {

            if (ContactData != null)
            {

                txtBoxFirstName.Text = ContactData.FirstName;
                txtBoxLastName.Text = ContactData.LastName;
                txtBoxHomePhone.Text = ContactData.PhoneData.HomePhone;
                txtBoxOfficePhone.Text = ContactData.PhoneData.OfficePhone;
                txtBoxEmailBusiness.Text = ContactData.EmailData.BusinessEmail;
                txtBoxEmailPrivate.Text = ContactData.EmailData.PrivateEmail;
                txtBoxStreet.Text = ContactData.AddressData.Street;
                txtBoxZipCode.Text = ContactData.AddressData.ZipCode;
                txtBoxCity.Text = ContactData.AddressData.City;
                cmbCountry.SelectedItem = ContactData.GetCountryName(ContactData.AddressData.Country);
            }

        }

        /// <summary>
        /// Property giving read and write access to customer contact data.
        /// </summary>
        public Contact ContactData
        {
            get { return contact; }
            set { contact = value; }
        }

        /// <summary>
        /// Read user input and send dialog result to the main form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            ReadNames(); //call method that collects name info
            ReadPhones(); //call method that collects phone info
            ReadEmails(); //call method that collects email info
            ReadAddress(); //call method that collects address info

            //check if obligatory fields not empty
            if (ContactData.CheckData())
            {
                this.DialogResult = DialogResult.OK; //send dialog result to the main form if check ok
                this.Close(); //close form
            }
            else
            {
                //display a message to make user fill obligatory fields if check not ok
                MessageBox.Show("Please provide at least first name or last name and city and country to save the information.");
                //set the dialog result to None so the form remains open
                this.DialogResult = DialogResult.None;
            }

        }

        /// <summary>
        /// Read first name and last name from the textbox and assign using properties.
        /// </summary>
        private void ReadNames()
        {
            contact.FirstName = txtBoxFirstName.Text;
            contact.LastName = txtBoxLastName.Text;
        }

        /// <summary>
        /// Read phones info from the textboxes and assign to a newly created phone object belonging to contact object (using properties).
        /// </summary>
        private void ReadPhones()
        {
            contact.PhoneData = new Phone
            {
                OfficePhone = txtBoxOfficePhone.Text,
                HomePhone = txtBoxHomePhone.Text,
            };

        }

        /// <summary>
        /// Read email info from the textboxes and assign to a newly created email object belonging to contact object (using properties).
        /// </summary>
        private void ReadEmails()
        {
            contact.EmailData = new Email
            {
                BusinessEmail = txtBoxEmailBusiness.Text,
                PrivateEmail = txtBoxEmailPrivate.Text,
            };

        }

        /// <summary>
        /// Read address info from the textboxes and assign to a newly created address object belonging to contact object (using properties).
        /// </summary>
        private void ReadAddress()
        {
            contact.AddressData = new Address
            {
                Street = txtBoxStreet.Text,
                City = txtBoxCity.Text,
                ZipCode = txtBoxZipCode.Text,
                Country = (Countries)cmbCountry.SelectedIndex
            };

            //set back the underscores when retrieving the value so it matches the actual content of enum Countries 
            contact.AddressData.Country = (Countries)Enum.Parse(typeof(Countries), cmbCountry.SelectedItem.ToString().Replace(" ", "_"), true);

        }

        /// <summary>
        /// Show a message box to the user to confirm the cancellation of actions and close the form if answer positive, otherwise leave it open.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //show a message box with yes/no options
            this.DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(this.DialogResult == DialogResult.Yes) //if yes selected
            { 
                this.Close(); //this form close

            } 
            else
            {
                this.DialogResult = DialogResult.None; //otherwise remain open
            }

        }
    }
}
