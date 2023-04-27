using System;
using System.Linq;
using System.Threading.Tasks;
using Vectra.Avaliacao.Backend.Application.Contratos;
using Vectra.Avaliacao.Backend.Application.DTOs;
using Vectra.Avaliacao.Backend.Domain.Contratos;

namespace Vectra.Avaliacao.Backend.Application
{
    public class ContaService : IContaService
    {
        public Task<ContaDto> SaveContas(ContaDto model)
        {
            throw new NotImplementedException();
        }
        public Task<bool> DeleteConta(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<ContaDto> GetAllContasAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ContaDto> GetContasByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }


        public Task<ContaDto> UpdateConta(int Id)
        {
            throw new NotImplementedException();
        }
    }
}