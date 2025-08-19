namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}
    private async void OnClicked(object sender, EventArgs e)
    {
       Launcher.Default.OpenAsync("https://github.com/Dylan-Marinss");
    }
}
