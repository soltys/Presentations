using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using Bing.Maps;
using DeliveryApp.Models;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DeliveryApp.Pages.Details
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class DetailsPage : DeliveryApp.Common.LayoutAwarePage
    {
        private DetailsPageViewModel _viewModel;

        public DetailsPage()
        {
            this.InitializeComponent();
            _viewModel = DataContext as DetailsPageViewModel;
        }


        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            _viewModel.Package = navigationParameter as Package;

            UpdateMap();
        }

        private void UpdateMap()
        {
            if (MyMap.Children.Count > 0)
            {
                MyMap.Children.RemoveAt(0);
            }
            Location location = _viewModel.Package.Location;
            const double zoomLevel = 14.0f;
            MyMap.SetView(location, zoomLevel);
        }


        protected override void SaveState(Dictionary<String, Object> pageState)
        {
        }
    }
}
