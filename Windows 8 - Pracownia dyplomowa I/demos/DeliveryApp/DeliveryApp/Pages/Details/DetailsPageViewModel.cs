using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Common;
using DeliveryApp.Models;

namespace DeliveryApp.Pages.Details
{
    class DetailsPageViewModel :BindableBase
    {
        public Package Package { get; set; }

    }
}
