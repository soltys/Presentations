using System;
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

        private string _address;
        public string Address
        {
            get { return _address; }
            set { SetProperty(ref _address, value); }
        }

        private DateTime _dueTime;
        public DateTime DueTime
        {
            get { return _dueTime; }
            set { SetProperty(ref _dueTime, value); }
        }

        private Priorities _priorities;
        public Priorities Priority
        {
            get { return _priorities; }
            set { SetProperty(ref _priorities, value); }
        }


        private bool _isDelivered;
        public bool IsDelivered
        {
            get { return _isDelivered; }
            set { SetProperty(ref _isDelivered,value); }
        }
    }
}
