using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConventerMauiApp.Converters
{
    internal class GradeToTextGradeConvernter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if(value == null || value is not string)
            {
                throw new Exception("Błędna wartość");
            }

            string grade = (value as string)!;

            string textGrade = grade switch
            {
                "1" => "ndst",
                "2" => "dop",
                "3" => "dos",
                "4" => "db",
                "5" => "bdb",
                "6" => "cel",
                "" => "",
                _ => "Błędne dame"
            };
            
            return textGrade;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
