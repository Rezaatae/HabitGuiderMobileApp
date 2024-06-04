using HabitGuiderMobileApp.ViewModels;

namespace HabitGuiderMobileApp.Views;

public partial class HabitsListView : ContentPage
{
	private readonly HabitsListViewModel _viewModel;
	public HabitsListView(HabitsListViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
        _viewModel = vm;
	}
}