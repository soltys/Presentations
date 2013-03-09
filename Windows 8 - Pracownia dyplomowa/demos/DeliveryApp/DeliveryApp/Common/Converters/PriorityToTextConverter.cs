using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;
using Windows.UI.Xaml.Data;

namespace DeliveryApp.Common.Converters
{
    class PriorityToTextConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            Priorities priority = (Priorities)value;
            switch (priority)
            {
                case Priorities.High:
                    return "High";
                case Priorities.Medium:
                    return "Medium";
                case Priorities.Low:
                    return "Low";
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
