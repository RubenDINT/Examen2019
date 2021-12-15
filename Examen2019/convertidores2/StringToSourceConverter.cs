using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Examen2019
{
    class StringToSourceConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            switch (value)
            {
                case "sol":
                    return "assets/sunny.png";
                case "nubes":
                    return "assets/cloudy.png";
                case "lluvia":
                    return "assets/raing.png";
                case "nieve":
                    return "assets/snow.png";
                default:
                    return "assets/sunny.png";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
