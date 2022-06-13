namespace MauiSqlite;
using SqliteRepository;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();
        builder.Services.AddSingleton(new AccountRepository("accounts.db"));
        builder.Services.AddScoped<MainPage>();
		builder.Services.AddScoped<ClientPage>();

		return builder.Build();
    }
}