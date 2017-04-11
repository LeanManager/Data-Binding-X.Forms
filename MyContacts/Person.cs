using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MyContacts
{
	public enum Gender { Male, Female };

    public class Person : INotifyPropertyChanged
	{
        public event PropertyChangedEventHandler PropertyChanged = delegate {};

		public string Name { get; set; }
		public string HeadshotUrl { get; set; }
		public string Email { get; set; }

        // --------------------------------------------------------------------------------------------------------- //

        DateTime dob;

        public DateTime Dob
        {
	      get
	      {
		     return dob;
	      }
	      set
			{
             // Make sure to compare the two values - it's inefficient to raise a property change notification if the value has not actually changed.
				if (dob != value)
				{
                 /* If the value has changed, then you need to raise the event (make sure to test for null!), 
					 passing the current object as the sender and a new PropertyChangedEventArgs with the 
					 text name of the property that has changed - in this case, that would be "Dob" */
					dob = value;
					// Can pass the property name as a string, -or- let the compiler do it because of the CallerMemberNameAttribute below.
					RaisePropertyChanged();
				}
			}
		}

        // --------------------------------------------------------------------------------------------------------- //

		public Gender Gender { get; set; }
		public bool IsFavorite { get; set; }

		// --------------------------------------------------------------------------------------------------------- //

        // .NET 4.5 includes a CallerMemberName attribute which you can use to identify the property that has been changed.
        void RaisePropertyChanged([CallerMemberName] string propertyName = "")
        {
			PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        // --------------------------------------------------------------------------------------------------------- //

		public override string ToString()
		{
			return string.Format("Name={0}, Email={1}, Dob={2}, Gender={3}, IsFavorite={4}", 
				this.Name, this.Email, this.Dob, this.Gender, this.IsFavorite);
		}

        // --------------------------------------------------------------------------------------------------------- //
	}
}
