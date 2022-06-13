namespace MauiSqlite;
using SqliteRepository;

public partial class ClientPage : ContentPage
{
    private readonly ClientRepository _clientRepository;

    public ClientPage(ClientRepository clientRepository)
    {
        _clientRepository = clientRepository;
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        GetClients();
    }

    private void AddClientClicked(object sender, EventArgs e)
    {
        var client = new Client()
        {
            Name = "Rokas",
            Surname = "Ma"
        };
        _clientRepository.CreateClient(client);
        GetClients();
    }

    private void UpdateClientClicked(object sender, EventArgs e)
    {
        if (collectionView.SelectedItem is null)
            return;

        var client = collectionView.SelectedItem as Client;
        if (client is null)
            return;

		// set the update here
        client.Name = "Mantas";
        _clientRepository.UpdateClient(client);
        GetClients();
    }

    private void DeleteClientClicked(object sender, EventArgs e)
    {
        if (collectionView.SelectedItem is null)
            return;

        var client = collectionView.SelectedItem as Client;
        if (client is null)
            return;

        _clientRepository.DeleteClient(client);
        GetClients();
    }
	/*
    private void Filter1ClientClicked(object sender, EventArgs e)
    {
        collectionView.ItemsSource = _clientRepository.QueryClientWithPositiveBalance();
    }

    private void Filter2ClientClicked(object sender, EventArgs e)
    {
        collectionView.ItemsSource = _clientRepository.LinqZeroBalance();
    }
	*/
    private void GetClients()
    {
        collectionView.ItemsSource = _clientRepository.GetClients();
    }
}
