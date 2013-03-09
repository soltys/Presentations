using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Service;

namespace DeliveryApp.Pages.Details
{
    class DetailsPageSampleData:DetailsPageViewModel
    {
        public DetailsPageSampleData()
        {
            Package = PackagesService.GeneratePackage();
        }
    }
}
