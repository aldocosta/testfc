using MongoDB.Driver;
using parkDriveApi.Models;

namespace parkDriveApi.Services
{
    public class ServiceDatabase : IServiceDatabase
    {
        private IMongoCollection<Veiculo> _Veiculos;

        public ServiceDatabase(IMongoClient client)
        {
            var database = client.GetDatabase("parkDrive");
            _Veiculos = database.GetCollection<Veiculo>("Veiculos");
        }

        public IMongoCollection<Veiculo> Veiculos
        {
            get => _Veiculos;
        }
    }
}