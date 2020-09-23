using MongoDB.Bson.Serialization.Attributes;

namespace parkDriveApi.Models
{
    public class Veiculo
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRequired]
        public string Marca { get; set; }

        [BsonRequired]
        public string Modelo { get; set; }

        [BsonRequired]
        public string Cor { get; set; }

        [BsonRequired]
        public string Placa { get; set; }

        [BsonRequired]
        public string Tipo { get; set; }
    }
}