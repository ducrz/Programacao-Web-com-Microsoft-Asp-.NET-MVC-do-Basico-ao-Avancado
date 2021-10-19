using Dados.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dados.Context
{
    public class LocadoraDbContext : IdentityDbContext
    {
        public LocadoraDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<ClienteDataModel> Cliente { get; set; }
        public DbSet<AluguelDataModel> Aluguel { get; set; }
        public DbSet<CarroDataModel> Carro { get; set; }
        public DbSet<CarroCategoriaDataModel> CarroCategoria { get; set; }
        public DbSet<ReservaDataModel> Reserva { get; set; }
    }
}
