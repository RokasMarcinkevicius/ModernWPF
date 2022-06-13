namespace MauiSqlite;
using Application = Microsoft.Maui.Controls.Application;

public partial class App : Application
{
    public App(IServiceProvider serviceProvider)
    {
        InitializeComponent();

        MainPage = serviceProvider.GetRequiredService<MainPage>();
		//ClientPage = serviceProvider.GetRequiredService<ClientPage>();

	}
}
