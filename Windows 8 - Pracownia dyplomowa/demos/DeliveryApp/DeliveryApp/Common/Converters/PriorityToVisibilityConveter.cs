using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace DeliveryApp.Common.Converters
{
    class PriorityToVisibilityConveter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            var priority = (Priorities)value;
            return priority != Priorities.NotSet ? Visibility.Visible : Visibility.Collapsed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
