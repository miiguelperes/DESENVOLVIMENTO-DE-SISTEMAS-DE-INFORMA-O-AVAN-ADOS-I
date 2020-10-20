using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.Veiculos.Dominio
{
    public class TipoVeiculo
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Categoria { get; set; }
        public string Situacao { get; set; }
        public int Ano { get; set; }
        public string Descricao { get; set; }
    }
}
