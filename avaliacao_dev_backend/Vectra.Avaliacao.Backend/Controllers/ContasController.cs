using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Vectra.Avaliacao.Backend.DTOs;
using Vectra.Avaliacao.Backend.Models;
using Vectra.Avaliacao.Backend.Interfaces;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Vectra.Avaliacao.Backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContasController : ControllerBase
    {
        private readonly IEFContext _dbContext;

        public ContasController(IEFContext dbContext, IResponse response)
        {
            _dbContext = dbContext;
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
        public string Post()
        {
            return "Exemplo de Post";
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
}
