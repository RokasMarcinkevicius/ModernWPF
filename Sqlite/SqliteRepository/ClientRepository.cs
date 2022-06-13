namespace SqliteRepository;
using SQLite;

public class ClientRepository
{
    private readonly SQLiteConnection _database;

    public ClientRepository(string dbName)
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Client>();
    }

    public List<Client> GetClients()
    {
        return _database.Table<Client>().ToList();
    }

    public int CreateClient(Client client)
    {
        return _database.Insert(client);
    }

    public int UpdateClient(Client client)
    {
        return _database.Update(client);
    }

    public int DeleteClient(Client client)
    {
        return _database.Delete(client);
    }

	public void DeleteClientsWithoutOrders()
	{
		List<Client> clients = _database.Table<Client>().ToList();

		foreach (Client client in clients)
		{
			if(client.HasOrder == false)
			{
				_database.Delete(client);
			}
		}
	}
}