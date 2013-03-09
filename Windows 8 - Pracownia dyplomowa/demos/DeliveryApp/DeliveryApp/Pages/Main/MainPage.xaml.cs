using System;
using System.Collections.Generic;
using DeliveryApp.Common;
using DeliveryApp.Pages.Details;
using DeliveryApp.Service;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace DeliveryApp.Pages.Main
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : DeliveryApp.Common.LayoutAwarePage
    {
        private MainPageViewModel _viewModel;
        public MainPage()
        {
            this.InitializeComponent();
            _viewModel = DataContext as MainPageViewModel;
        }

       
        protected override void LoadState(Object navigationParameter, Dictionary<String, Object> pageState)
        {
            _viewModel.Packages = PackagesService.Packages;
        }

        protected override void SaveState(Dictionary<String, Object> pageState)
        {

        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            PackagesService.AddPackage();
        }

        private void ItemGridView_OnItemClick(object sender, ItemClickEventArgs e)
        {
            Frame.Navigate(typeof(DetailsPage), e.ClickedItem);
        }
    }
}
