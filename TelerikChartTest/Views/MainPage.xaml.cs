using System;

using TelerikChartTest.ViewModels;

using Windows.UI.Xaml.Controls;

namespace TelerikChartTest.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.AddToChart();
        }

        private void Button_Click_1(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            ViewModel.AddEventChart();
        }
    }
}
