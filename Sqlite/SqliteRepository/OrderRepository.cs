namespace SqliteRepository;
using SQLite;

public class OrderRepository
{
    private readonly SQLiteConnection _database;

    public OrderRepository(string dbName)
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Order>();
    }

    public List<Order> GetOrders()
    {
        return _database.Table<Order>().ToList();
    }

    public int CreateOrder(Order order)
    {
        return _database.Insert(order);
    }

    public int UpdateOrder(Order order)
    {
        return _database.Update(order);
    }

    public int DeleteOrder(Order order)
    {
        return _database.Delete(order);
    }
}