using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyContacts
{
  /* The IValueConverter interface defines a contract a single binding can use to coerce or convert 
	 a property value from a model, into something usable by the UI property it is data bound to. */
  public class GenderToIndexConverter : IValueConverter
  {
     /* The Convert method should take the inbound Gender value and cast it to an integer value, then return it. 
		If you'd like to add some type checking code, you can test the targetType against an integer to make sure 
		the converter is being used properly at runtime. */
	 public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	 {
		Gender gender = (Gender)value;

		if (targetType != typeof(int))
			throw new Exception("GenderConverter.Convert expected integer targetType.");
		    return (int)gender;
	 }

     // The ConvertBack method should take the inbound integer index value and cast it back to a Gender and return it.
	 public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	 {
		int index = (int)value;

		if (targetType != typeof(Gender))
			throw new Exception("GenderConverter.ConvertBack expected Gender targetType");
		    return (Gender)index;
	 }

   }
}
