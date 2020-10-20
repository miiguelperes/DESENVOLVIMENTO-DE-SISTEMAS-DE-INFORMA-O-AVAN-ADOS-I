using Locadora.Veiculos.Dominio;
using Locadora.Veiculos.Generica.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Veiculos.Dados.Entity.TypeConfiguration
{
    class TipoVeiculoTypeConfiguration : LocadoraEntityAbstractConfig<TipoVeiculo>
    {
        protected override void ConfigurarCamposTabela()
        {
            Property(p => p.Id)
                .IsRequired()
                .HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity)
                .HasColumnName("Id");
            Property(p => p.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Nome");
            Property(p => p.Categoria)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnName("Categoria");
            Property(p => p.Situacao)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("Situacao");
            Property(p => p.Ano)
                .IsRequired()
                .HasColumnName("Ano");
            Property(p => p.Descricao)
                .IsRequired()
                .HasMaxLength(1000)
                .HasColumnName("Descricao");
            
        }

        protected override void ConfigurarChaveEstrangeira()
        {
        }

        protected override void ConfigurarChavePrimaria()
        {
            HasKey(pk => pk.Id);
        }

        protected override void ConfigurarNomeTabela()
        {
            ToTable("TipoVeiculo");
        }
    }
}
