namespace SqliteRepository;
using SQLite;
using System.ComponentModel.DataAnnotations.Schema;

public class Order
{
	[PrimaryKey, AutoIncrement]
	public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int ClientId { get; set; }
}

