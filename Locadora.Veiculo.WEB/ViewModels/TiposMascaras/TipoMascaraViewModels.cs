using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Projeto.AtelierVera.WEB.ViewModels.TiposMascaras
{
    public class TipoMascaraViewModels
    {
        [Required(ErrorMessage = "O Id é obrigatório")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Nome é obrigatório")]
        [MaxLength(100, ErrorMessage =("O Nome da Mascara deve ter no máximo 100 caracteres"))]
        [Display(Name = "Nome do Tipo de Mascara")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Tecido é obrigatório")]
        [MaxLength(50, ErrorMessage = ("O Tecido deve ter no máximo 50 caracteres"))]
        [Display(Name = "Tecido utilizado na Mascara")]
        public string Tecido { get; set; }

        [Required(ErrorMessage = "A Cor é obrigatório")]
        [MaxLength(50, ErrorMessage = ("A Cor deve ter no máximo 50 caracteres"))]
        [Display(Name = "Cor da Mascara")]
        public string Cor { get; set; }

        [Required(ErrorMessage = "Obrigatório colocar a Descrição")]
        [MaxLength(1000, ErrorMessage = ("A Descrição deve ter no máximo 1000 caracteres"))]
        [Display(Name = "Descrição do Tipo de Mascara")]
        public string Descricao { get; set; }
    }
}