using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Telerik.UI.Xaml.Controls.Chart;
using TelerikChartTest.Models;
using TelerikChartTest.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace TelerikChartTest.Controls
{
    public sealed partial class ChartUC : UserControl
    {
        private ChartUserControlViewModel ViewModel = new ChartUserControlViewModel();

        public ChartUC()
        {
            this.InitializeComponent();
            this.DataContext = ViewModel;
        }

        public ObservableCollection<ChartModel> ChartItems
        {
            get { return GetValue(ChartItemsProperty) as ObservableCollection<ChartModel>; }
            set
            {
                SetValue(ChartItemsProperty, value);
            }
        }
        public static readonly DependencyProperty ChartItemsProperty = DependencyProperty.Register("ChartItems", typeof(ObservableCollection<ChartModel>), typeof(ChartUC), new PropertyMetadata(null));


        public ObservableCollection<ChartEvent> ChartEventItems
        {
            get { return GetValue(ChartEventProperty) as ObservableCollection<ChartEvent>; }
            set
            {
                SetValue(ChartEventProperty, value);

            }
        }
        public static readonly DependencyProperty ChartEventProperty = DependencyProperty.Register("ChartEvents", typeof(ObservableCollection<ChartEvent>), typeof(ChartUC), new PropertyMetadata(null));


        private void UpdateChartAnnotation()
        {
            CartesianGridLineAnnotation myLineAnnotation = new CartesianGridLineAnnotation
            {
                Axis = Chart.HorizontalAxis,
                Value = ChartEventItems[ChartEventItems.Count - 1].EventStart,
                Stroke = new SolidColorBrush(Windows.UI.Colors.Red)
            };

            Chart.Annotations.Add(myLineAnnotation);

            var newLabel = new CartesianCustomAnnotation
            {
                HorizontalAxis = horizontalAxis,
                VerticalAxis = verticalAxis
            };

            var border = new Border
            {
                //Background = new SolidColorBrush(Windows.UI.Colors.Gray),
                VerticalAlignment = VerticalAlignment.Top,
                Opacity = 0.9
            };

            var content = new TextBlock
            {
                Text = ChartEventItems[ChartEventItems.Count - 1].EventDescription
            };
            border.Child = content;
            newLabel.Content = border;
            newLabel.HorizontalValue = ChartEventItems[ChartEventItems.Count - 1].EventStart;

            newLabel.HorizontalAlignment = HorizontalAlignment.Left;
            newLabel.VerticalAlignment = VerticalAlignment.Top;
            newLabel.VerticalValue = 80d;                          // Position on Y axis
            newLabel.Tag = "label";
            newLabel.Visibility = Visibility.Visible;
            newLabel.ClipToPlotArea = false;
            Chart.Annotations.Add(newLabel);
        }

        private void ChartTrackBallBehavior_TrackInfoUpdated(object sender, Telerik.UI.Xaml.Controls.Chart.TrackBallInfoEventArgs e)
        {
            ViewModel.TrackBallContext = e.Context;
            ViewModel.UpdateValues(e.Context);
        }

        int AddedAnnotations = 0;

        private void Chart_LayoutUpdated(object sender, object e)
        {
            if (ChartEventItems.Count > AddedAnnotations)
            {
                AddedAnnotations = ++AddedAnnotations;
                UpdateChartAnnotation();
            }
        }
    }
}
