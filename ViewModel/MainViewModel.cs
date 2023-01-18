using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace FichadorPersonal.ViewModel
{

    public partial class MainViewModel : ObservableObject
    {
        [ObservableProperty]
        string title;

        [ObservableProperty]
        int count;

        [ObservableProperty]
        string buttonText;

        public MainViewModel()
        {
            Title = "Home";

            ButtonText = "Click me!";
        }

         [RelayCommand]
         void OnCounterClicked()
         {
            count++;

            if (count == 1)
                ButtonText = $"Clicked {count} time";
            else
                ButtonText = $"Clicked {count} times";

         }
    }
}
