using Locadora.Veiculos.Dados.Entity.TypeConfiguration;
using Locadora.Veiculos.Dominio;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Veiculos.Dados.Entity.Context
{
    public class VeiculoDbContext : DbContext
    {
        public DbSet<TipoVeiculo> TiposVeiculos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new TipoVeiculoTypeConfiguration());
        }
    }
}
