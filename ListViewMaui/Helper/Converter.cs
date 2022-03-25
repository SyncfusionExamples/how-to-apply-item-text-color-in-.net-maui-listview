using System.Globalization;

namespace ListViewMaui
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value == null)
                return false;
            var itemdata = value as Contacts;
            if (itemdata.ContactType == "HOME")
                return Colors.RoyalBlue;
            else if (itemdata.ContactType == "WORK")
                return Colors.PaleGreen;
            else if (itemdata.ContactType == "MOBILE")
                return Colors.HotPink;
            else if (itemdata.ContactType == "OTHER")
                return Colors.DarkGoldenrod;
            else
                return Colors.BlueViolet;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
