using AutoMapper;
using Projeto.AtelierVera.WEB.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.App_Start
{
    public static class AutoMapperConfig
    {
        public static void Configurar()
        {
            Mapper.AddProfile<DominioParaViewModelsProfile>();
            Mapper.AddProfile<ViewModelsParaDominioProfile>();
        }
    }
}