using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Data;

namespace CropRotate
{
    public class InversionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if(value.GetType() == typeof(double))
            {
                return -((double)value);
            }

            return value;
        }
        
        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (value == typeof(double))
            {
                return -((double)value);
            }

            return value;
        }
    }
}
