using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Common;
using DeliveryApp.Models;

namespace DeliveryApp.Pages.Main
{
    class MainPageViewModel : BindableBase
    {
        private ObservableCollection<Package> _packages;
        public ObservableCollection<Package> Packages
        {
            get { return _packages; }
            set { SetProperty(ref _packages, value); }
        }
    }
}
