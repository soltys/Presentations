using System;
using Bing.Maps;
using DeliveryApp.Common;

namespace DeliveryApp.Models
{
    class Package : BindableBase
    {
        private string _packageGuid = Guid.NewGuid().ToString();
        public string PackageGuid
        {
            get { return _packageGuid; }
        }

        private string _name;
        public string Name
        {
            get { return _name; }
            set { SetProperty(ref _name, value); }
        }

        private string _description;
        public string Description
        {
            get { return _description; }
            set { SetProperty(ref _description, value); }
        }

        private string _city;
        public string City
        {
            get { return _city; }
            set { SetProperty(ref _city, value); }
        }
        
   
        private Priorities _priorities;
        public Priorities Priority
        {
            get { return _priorities; }
            set { SetProperty(ref _priorities, value); }
        }

        private Location _location;
        public Location Location
        {
            get { return _location; }
            set { SetProperty(ref _location, value); }
        }

        private bool _isDelivered;
        public bool IsDelivered
        {
            get { return _isDelivered; }
            set { SetProperty(ref _isDelivered, value); }
        }
    }
}
