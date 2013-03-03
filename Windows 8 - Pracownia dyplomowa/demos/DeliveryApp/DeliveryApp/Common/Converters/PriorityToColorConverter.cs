using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace DeliveryApp.Common.Converters
{
    class PriorityToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            try
            {
                Priorities priorities = (Priorities)value;
                switch (priorities)
                {
                    case Priorities.NotSet:
                        return new SolidColorBrush(Colors.Transparent);
                    case Priorities.Low:
                        return new SolidColorBrush(Colors.SteelBlue);
                    case Priorities.Medium:
                        return new SolidColorBrush(Colors.DarkGoldenrod);
                    case Priorities.High:
                        return new SolidColorBrush(Colors.Crimson);
                    default:
                        return new SolidColorBrush(Colors.Transparent);
                }
            }
            catch
            {
                return new SolidColorBrush(Colors.Transparent);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
