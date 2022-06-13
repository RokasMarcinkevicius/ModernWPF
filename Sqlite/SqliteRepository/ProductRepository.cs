namespace SqliteRepository;
using SQLite;

public class ProductRepository
{
    private readonly SQLiteConnection _database;

    public ProductRepository(string dbName)
    {
        var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), dbName);
        _database = new SQLiteConnection(dbPath);
        _database.CreateTable<Product>();
    }

    public List<Product> GetProducts()
    {
        return _database.Table<Product>().ToList();
    }

    public int CreateProduct(Product product)
    {
        return _database.Insert(product);
    }

    public int UpdateProduct(Product product)
    {
        return _database.Update(product);
    }

    public int DeleteProduct(Product product)
    {
        return _database.Delete(product);
    }
}