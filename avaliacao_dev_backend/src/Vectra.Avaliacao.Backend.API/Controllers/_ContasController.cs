using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Vectra.Avaliacao.Backend.Domain;
using Vectra.Avaliacao.Backend.Application.Interfaces;
/*using Vectra.Avaliacao.Backend.Application.Interfaces.Interfaces;
using Vectra.Avaliacao.Backend.Application.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vectra.Avaliacao.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IEFContext _dbContext;
        private readonly IResponse _response;

        public ContasController(IEFContext dbContext, IResponse response)
        {
            _dbContext = dbContext;
            _response = response;
        }

        // GET: api/<ContasController>
        [HttpGet]
        public IEnumerable<Conta> Get()
        {
            return _dbContext.Contas;
        }

        // GET api/<ContasController>/5W
        [HttpGet("{id}")]
        public Conta GeById(int id)
        {
            return _dbContext.Contas.FirstOrDefault(
                    contas => contas.Id == id);
        }

        // POST api/<ContasController>
        [HttpPost]
        public Task<Response> Post([FromBody] Conta conta)
        {
            conta.CreatedAt = DateTime.Now;
            conta.IsActive = true;
            _dbContext.Contas.Add(conta);
            var changes = _dbContext.SaveChangesAsync();
            string message = changes.Result <= 0 ? "Ocorreu um erro ao tentar criar a conta" : "Operação realizada com sucesso";
            return _response.GenerateResponse(statusCode: HttpStatusCode.OK, hasError: changes.Result <= 0, message, null);

        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de Put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}*/
