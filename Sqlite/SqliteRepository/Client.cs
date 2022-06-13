namespace SqliteRepository;
using SQLite;

public class Client
{
    [PrimaryKey, AutoIncrement]
    public int ClientId { get; set; }
    public string Name { get; set; } = string.Empty;
	public string Surname { get; set; } = string.Empty;
	public bool HasOrder { get; set; } = false;
}

