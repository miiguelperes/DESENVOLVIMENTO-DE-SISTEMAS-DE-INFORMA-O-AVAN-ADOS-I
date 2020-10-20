using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.ViewModels.TiposVeiculos
{
    public class TipoVeiculoIndexViewModels
    {
        public int Id { get; set; }

        [Display(Name = "Nome do Veiculo")]
        public string Nome { get; set; }

        [Display(Name = "Categoria utilizado na Veiculo")]
        public string Categoria { get; set; }
        [Display(Name = "Situação do Veiculo")]

        public string Situacao { get; set; }

        [Display(Name = "Ano do Veiculo")]
        public int Ano { get; set; }

        [Display(Name = "Descrição do  Veiculo")]
        public string Descricao { get; set; }




    }
}