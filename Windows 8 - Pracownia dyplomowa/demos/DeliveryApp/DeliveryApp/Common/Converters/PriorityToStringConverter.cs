using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;
using Windows.UI.Xaml.Data;

namespace DeliveryApp.Common.Converters
{
    class PriorityToStringConverter : IValueConverter
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
                    return "Not set";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {

            string stringPriority = value as string;
            switch (stringPriority)
            {
                case "High" :
                    return Priorities.High;
                case "Medium":
                    return Priorities.Medium ;
                case "Low":
                    return Priorities.Low;
                default:
                    return Priorities.NotSet;
            }
            
        }
    }
}
