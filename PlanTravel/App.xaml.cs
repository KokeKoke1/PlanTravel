using Microsoft.Maui.Controls;
using Microsoft.Maui.ApplicationModel;

namespace PlanTravel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            RequestLocationPermissionAsync(); 

        }

        private async void RequestLocationPermissionAsync()
        {
            try
            {
                var status = await Permissions.CheckStatusAsync<Permissions.LocationWhenInUse>();

                if (status != PermissionStatus.Granted)
                {
                    status = await Permissions.RequestAsync<Permissions.LocationWhenInUse>();
                }

                if (status != PermissionStatus.Granted)
                {
                    await MainPage.DisplayAlert(
                        "Brak uprawnień",
                        "Nie zezwolono na dostęp do lokalizacji. Niektóre funkcje mogą nie działać poprawnie.",
                        "OK");
                }
            }
            catch (Exception ex)
            {
                await MainPage.DisplayAlert("Błąd", $"Nie można sprawdzić uprawnień: {ex.Message}", "OK");
            }
        }
    }
}
