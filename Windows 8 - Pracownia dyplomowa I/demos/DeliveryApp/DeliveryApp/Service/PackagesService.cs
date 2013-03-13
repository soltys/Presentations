using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bing.Maps;
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
        private static readonly string[] _cities = new[] { "Szczecin", "Goleniów", "Gryfino" };

        static PackagesService()
        {
            for (int i = 0; i < 24; i++)
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
                array.Move(i, j + 1);
            }
        }


        private static Location CityToLocation(string cityName)
        {
            switch (cityName)
            {
                case "Szczecin":
                    return new Location(53.432701, 14.548066);
                case "Goleniów":
                    return new Location(53.563858, 14.828222);
                case "Gryfino":
                    return new Location(53.252380, 14.488230);
                default:
                    return new Location(53.432701, 14.548066);
            }
        }

        public static Package GeneratePackage()
        {
            string name = LoremIpsumService.GetWords(_randomGenerator.Next(2, 5));
            name = name.ToLowerInvariant();
            name = name.Substring(0, 1).ToUpperInvariant() + name.Substring(1);

            string city = _cities[_randomGenerator.Next(_cities.Length)];
            return new Package
                {
                    Name =  name,
                    Description = LoremIpsumService.GetWords(_randomGenerator.Next(15,20)),
                    City =  city,
                    Location = CityToLocation(city),
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
