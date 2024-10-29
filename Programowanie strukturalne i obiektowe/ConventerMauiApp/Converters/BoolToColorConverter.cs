using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventerMauiApp.Converters
{
    class BoolToColorConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null || value is not bool)
            {
                throw new Exception("Błąd");
            }

            bool isChecked = (bool)value;

            if (isChecked)
            {
                return new Color(0, 255, 0);
                //return Colors.Green;
            }
            else
                return Colors.Red;

        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
