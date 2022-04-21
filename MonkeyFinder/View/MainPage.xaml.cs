using MonkeyFinder.Model;
using MonkeyFinder.ViewModel;

namespace MonkeyFinder.View;

public partial class MainPage : ContentPage
{
    public MainPage(MonkeysViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.Count == 0 || e.CurrentSelection[0] is not Monkey monkey)
        {
            return;
        }

        await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
        {
            {"Monkey", monkey }
        });

        ((CollectionView)sender).SelectedItem = null;
    }
}