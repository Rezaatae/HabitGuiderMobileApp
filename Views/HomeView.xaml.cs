using HabitGuiderMobileApp.ViewModels;

namespace HabitGuiderMobileApp.Views;

public partial class HomeView : ContentPage
{
	private readonly HomeViewModel _viewModel;
	public HomeView(HomeViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
		_viewModel = vm;
	}
}