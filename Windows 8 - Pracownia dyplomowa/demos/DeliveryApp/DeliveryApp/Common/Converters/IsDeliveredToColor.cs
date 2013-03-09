using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace DeliveryApp.Common.Converters
{
    class IsDeliveredToColor:IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isDelivered = (bool) value;
            if (isDelivered)
            {
                return new SolidColorBrush(Colors.DarkGreen);
            }
            else
            {
                return new SolidColorBrush(Colors.DimGray);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
