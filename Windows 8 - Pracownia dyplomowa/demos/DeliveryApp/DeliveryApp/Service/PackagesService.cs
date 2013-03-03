using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeliveryApp.Models;

namespace DeliveryApp.Service
{
    static class PackagesService
    {
        private static readonly ObservableCollection<Package> _packages = new ObservableCollection<Package>();
        public static ObservableCollection<Package> Packages
        {
            get { return _packages; }
        }
        static readonly Random _randomGenerator = new Random();
        private static readonly string[] _cities = new[] { "Szczecin", "Goleniów", "Mierzyn" };

        static PackagesService()
        {
            for (int i = 0; i < 16; i++)
            {
                _packages.Add(GeneratePackage());
            }
            InsertSort(_packages);
        }

        static void InsertSort(ObservableCollection<Package> array)
        {
            int i, j;

            for (i = 1; i < array.Count; i++)
            {
                Package value = array[i];
                j = i - 1;
                while ((j >= 0) && (array[j].City.CompareTo(value.City) > 0))
                {
                    j--;
                }
                array.Move(i,j+1);
            }
        }

        private static Package GeneratePackage()
        {
            return new Package
                {
                    Name = LoremIpsumService.GetWords(_randomGenerator.Next(2, 5)),
                    City = _cities[_randomGenerator.Next(_cities.Length)],
                    DueTime = DateTime.Now.AddDays(_randomGenerator.Next(1, 4)),
                    Priority = (Priorities)_randomGenerator.Next(5),
                };
        }

        public static void AddPackage()
        {
            _packages.Add(GeneratePackage());
            InsertSort(_packages);
        }
    }
}
