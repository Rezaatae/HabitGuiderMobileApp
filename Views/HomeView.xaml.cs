using HabitGuiderMobileApp.ViewModels;
using Microcharts;
using SkiaSharp;

namespace HabitGuiderMobileApp.Views;

public partial class HomeView : ContentPage
{
    ChartEntry[] entries = new[]
        {
            new ChartEntry(212)
            {
                Label = "Windows",
                ValueLabel = "112",
                Color = SKColor.Parse("#2c3e50")
            },
            new ChartEntry(248)
            {
                Label = "Android",
                ValueLabel = "648",
                Color = SKColor.Parse("#77d065")
            },
            new ChartEntry(128)
            {
                Label = "iOS",
                ValueLabel = "428",
                Color = SKColor.Parse("#b455b6")
            },
            new ChartEntry(514)
            {
                Label = ".NET MAUI",
                ValueLabel = "214",
                Color = SKColor.Parse("#3498db")
            }
        };
    private readonly HomeViewModel _viewModel;
	public HomeView(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		_viewModel = vm;

        chartView.Chart = new RadialGaugeChart
        {
            Entries = entries
        };


    }
}