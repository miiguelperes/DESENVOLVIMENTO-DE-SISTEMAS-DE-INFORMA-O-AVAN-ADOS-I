using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.ViewModels.TiposMascaras
{
    public class TipoMascaraIndexViewModels
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Tipo de Mascara")]
        public string Nome { get; set; }

        [Display(Name = "Tecido utilizado na Mascara")]
        public string Tecido { get; set; }

        [Display(Name = "Cor da Mascara")]
        public string Cor { get; set; }

        [Display(Name = "Descrição do Tipo de Mascara")]
        public string Descricao { get; set; }
    }
}