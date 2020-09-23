using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using parkDriveApi.Models;
using parkDriveApi.Services;

namespace parkDriveApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly IServiceDatabase _ServiceDatabase;

        public VeiculosController(IServiceDatabase ServiceDatabase)
        {
            _ServiceDatabase = ServiceDatabase;
        }

        [HttpGet]
        public IList<Veiculo> Get()
        {
            var ret = _ServiceDatabase.Veiculos.Find(_ => true).ToList();
            return ret;
        }

        [HttpPost]
        public string Post(Veiculo veiculo)
        {
            _ServiceDatabase.Veiculos.InsertOne(veiculo);
            return "Registro inserido";
        }

        [HttpDelete]
        [Route("{id}")]
        public string Delete(String id)
        {
            string ret = _ServiceDatabase.Veiculos.DeleteOne(v => v.Id == id).DeletedCount.ToString();
            return "Registros ${ret} removidos";
        }

        // [HttpPut]
        // [Route("{id}")]
        // public string Put(String id, Veiculo veiculo)
        // {
        //     string ret = _ServiceDatabase.Veiculos.UpdateOne(v => v.Id == id, veiculo);
        //     return "Registros ${ret} removidos";
        // }
    }
}
