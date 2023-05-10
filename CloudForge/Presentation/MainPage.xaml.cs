using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Navigation;

namespace CloudForge.Presentation
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            RAMAllocation.Value = 1;
            RAMText.Text = "1 GB";
        }
        private void RAMAllocation_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            int ramValue = (int)e.NewValue;
            RAMText.Text = $"{ramValue} GB";
        }

        private async void AzureSignIn_Click(object sender, RoutedEventArgs e)
        {
            // Collect user input
            string serverName = ServerName.Text;
            string serverModerator = ServerModerator.Text;
            string motd = MOTD.Text;
            string modpackLink = ModpackLink.Text;
            int ramAllocation = (int)RAMAllocation.Value;

            // Authenticate with Azure, create resources, and configure the server
            // ...
        }
    }
}