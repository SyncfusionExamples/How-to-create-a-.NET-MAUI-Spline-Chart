using Syncfusion.Maui.Charts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Syncfusion_Dot_NET_MAUI_Spline_Charts
{
    public class SplineChartDemo : ContentPage
    {
        public SplineChartDemo()
        {
            SfCartesianChart chart = new SfCartesianChart();
            chart.BindingContext = new ViewModel();

            //Initializing Primary Axis
            CategoryAxis primaryAxis = new CategoryAxis();
            chart.XAxes.Add(primaryAxis);

            //Initializing Secondary Axis
            NumericalAxis secondaryAxis = new NumericalAxis();
            chart.YAxes.Add(secondaryAxis);

            //Initialize series
            var binding = new Binding() { Path = "Data" };
            var splineSeries = new SplineSeries()
            {
                XBindingPath = "Name",
                YBindingPath = "Height",
                ShowDataLabels = true,
                Fill = new SolidColorBrush(Color.FromArgb("#314A6E")),
            };

            splineSeries.SetBinding(ChartSeries.ItemsSourceProperty, binding);
            chart.Series.Add(splineSeries);

            //Chart title
            var title = new Label()
            {
                HorizontalOptions = LayoutOptions.Fill,
                HorizontalTextAlignment = TextAlignment.Center,
                Text = "Height of Students",
                Margin = new Thickness(5, 10, 5, 10),
            };
            chart.Title = title;

            var grid = new Grid()
            {
                HorizontalOptions = LayoutOptions.Fill,
                VerticalOptions = LayoutOptions.Fill,
                Padding = new Thickness(20),
            };

            grid.Children.Add(chart);

            this.Content = grid;
        }
    }
 }

