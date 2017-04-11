using System;
using System.Globalization;
using Xamarin.Forms;

namespace MyContacts
{
   public class ImageResourceConverter : IValueConverter
   {
      /* The Convert method should take the inbound string value, add the proper prefix (you can 
		 see it in the current code behind) and then pass it all to the ImageSource.FromResource 
		 method to load the embedded resource and return the image. */	
	  public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	  {
		  return ImageSource.FromResource("MyContacts.Images." + (value ?? ""));
	  }
      
      /* Since this is a one-way binding (we can't change the image), the ConvertBack method 
		 should throw a NotSupportedException so users of the value converter will get a 
		 runtime failure if they attempt to use it on a two-way binding. */
	  public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	  {
		  throw new NotSupportedException();
	  }
}
}
