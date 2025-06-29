namespace PlanTravel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            blazorWebView.BlazorWebViewInitialized += OnBlazorWebViewInitialized;
        }

        private async void OnBlazorWebViewInitialized(object sender, EventArgs e)
        {
            await Task.Delay(1000);
            // Gdy Blazor załaduje się, ukryj loader
            LoadingOverlay.IsVisible = false;
        }
    }

}
