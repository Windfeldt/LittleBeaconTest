using System;
using Xamarin.Forms;
using MyLittleBeaconOpgave.Models;
using System.IO;

namespace MyLittleBeaconOpgave.Converter
{
    public class ByteConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ImageSource.FromStream(() => new MemoryStream((byte[])value));
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return ImageSource.FromStream(() => new MemoryStream((byte[])value));
        }
    }
}

