using Catalog.API.Entities;
using MongoDB.Driver;

namespace Catalog.API.Data
{
    public class CatalogContext : ICatalogContext
    {
        public CatalogContext(IConfiguration config)
        {
            var client = new MongoClient(config.GetValue<string>(
                "databaseSettings: ConnectionString"));

            var database = client.GetDatabase(config.GetValue<string>(
            "databaseSettings: DatabaseName"));

            Products = database.GetCollection<Product>(config.GetValue<string>(
            "databaseSettings: CollectionName"));
            CatalogContextSeed.SeedData(Products);
        }
        public IMongoCollection<Product> Products { get; }
    }
}
