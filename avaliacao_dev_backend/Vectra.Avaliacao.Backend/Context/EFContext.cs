using Microsoft.EntityFrameworkCore;
using System;
using System.Threading;
using System.Threading.Tasks;
using Vectra.Avaliacao.Backend.Models;
using Vectra.Avaliacao.Backend.Interfaces;

namespace Vectra.Avaliacao.Backend.Context
{
    public class EFContext : DbContext, IEFContext
    {
        public EFContext(DbContextOptions<EFContext> options) : base(options) { }
        public DbSet<Conta> Contas { get; set; }


    }
}
