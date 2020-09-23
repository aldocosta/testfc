using MongoDB.Driver;
using parkDriveApi.Models;

namespace parkDriveApi.Services
{
    public interface IServiceDatabase
    {
        public IMongoCollection<Veiculo> Veiculos { get; }
    }
}