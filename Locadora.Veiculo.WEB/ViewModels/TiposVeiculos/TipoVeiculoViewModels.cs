using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.ViewModels.TiposVeiculos
{
    public class TipoVeiculoViewModels
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }


        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(100, ErrorMessage = ("O Nome do veiculo deve ter no máximo 100 caracteres"))]
        [Display(Name = "Nome do Tipo de veiculo")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "A Categoria é obrigatório")]
        [Display(Name = "Categoria utilizado na Veiculo")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Situação é obrigatória")]
        [Display(Name = "Situação do Veiculo")]
        public string Situacao { get; set; }

        [Required(ErrorMessage = "Ano do Veiculo é obrigatório")]
        [Display(Name = "Ano do Veiculo")]
        public int Ano { get; set; }

        [Required(ErrorMessage = "Obrigatório colocar a Descrição")]
        [MaxLength(1000, ErrorMessage = ("A Descrição deve ter no máximo 1000 caracteres"))]
        [Display(Name = "Descrição do Tipo de Veiculo")]
        public string Descricao { get; set; }

    }
}