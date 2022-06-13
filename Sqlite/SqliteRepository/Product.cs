namespace SqliteRepository;
using SQLite;


public class Product
{
	[PrimaryKey, AutoIncrement]

	public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;
	public long Price { get; set; }
}
