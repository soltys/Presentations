using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;
using DeliveryApp.Service;

namespace DeliveryApp.Pages.Main
{
    class MainPageSampleData:MainPageViewModel
    {
        public MainPageSampleData()
        {
            var oc = new ObservableCollection<Package>();
            for (int i = 0; i < 12; i++)
            {
                oc.Add(PackagesService.GeneratePackage());
            }
            Packages = oc;
        }
    }
}
