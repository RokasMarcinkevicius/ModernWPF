namespace MauiSqliteBlazor;
using SqliteRepository;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder.UseMauiApp<App>();

        builder.Services.AddMauiBlazorWebView();
		builder.Services.AddSingleton(new ClientRepository("clients-blazor.db"));
		builder.Services.AddSingleton(new OrderRepository("order-blazor.db"));
		builder.Services.AddSingleton(new ProductRepository("product-blazor.db"));

#if DEBUG
		builder.Services.AddBlazorWebViewDeveloperTools();
#endif
		return builder.Build();
    }
}
