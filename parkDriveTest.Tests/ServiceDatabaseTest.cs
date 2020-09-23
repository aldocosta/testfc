using System;
using System.Threading.Tasks;
using MongoDB.Driver;
using Moq;
using parkDriveApi.Models;
using parkDriveApi.Services;
using Xunit;

namespace parkDriveTest.Tests
{

    public class ServiceDatabaseTest
    {
        //private IServiceDatabase _database;
        private readonly ServiceDatabase _sut;
        private readonly Mock<IMongoClient> _mongoClientMock = new Mock<IMongoClient>();

        public ServiceDatabaseTest()
        {            
            _sut = new ServiceDatabase(_mongoClientMock.Object);
        }

        [Fact]
        public async Task GetAllVeiculos()
        {
            //arrange
            _mongoClientMock.Setup(x=>x.GetDatabase())

            //act
            var vei = await _sut.Veiculos.FindAsync(_ => true);
            var lista = await vei.ToListAsync();

            //assert
            Assert.True(lista.Count > 0, "Deveria retornar mais que zero itens");
        }

      
    }
}
