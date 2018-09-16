using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace FileExplorer.GUI.Converters
{
    class ColorToHexConverter : IValueConverter
    {
        Color color = new Color();
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            color = (Color)value;
            return $"#{color.A.ToString("X2")}{color.R.ToString("X2")}{color.G.ToString("X2")}{color.B.ToString("X2")}" ;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
