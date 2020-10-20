using AutoMapper;
using Locadora.Veiculos.Dominio;
using Projeto.AtelierVera.WEB.ViewModels.TiposVeiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.AutoMapper
{
    public class DominioParaViewModelsProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<TipoVeiculo, TipoVeiculoIndexViewModels>();
        }
    }
}