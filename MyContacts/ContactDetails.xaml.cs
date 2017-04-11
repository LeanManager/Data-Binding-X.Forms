using System;
using System.Linq;
using Xamarin.Forms;

namespace MyContacts
{
    public partial class ContactDetails : ContentPage
    {
        readonly Person person;

		// Initialized with an instance of the Person class created by the method in the SimpsonFactory class
		public ContactDetails(Person person)
        {
			BindingContext = person;

            this.person = person;
            InitializeComponent();			                        		          
        }

        void OnShow(object sender, EventArgs e)
        {
            // Add a year to the Person.Dob property by calling .AddYear(1) and assigning the returning value back to the Dob property. 
			// Note: You must assign the property since DateTime is immutable.
			person.Dob = person.Dob.AddYears(1);
            this.DisplayAlert("Selected Contact", person.ToString(), "OK");
        }
    }
}
