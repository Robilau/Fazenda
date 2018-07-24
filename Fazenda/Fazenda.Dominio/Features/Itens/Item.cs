using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.Dominio.Features.Itens
{
    public class Item
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Descricao) || Descricao.Length > 70) throw new ItemDescricaoInvalidaExcecao();
        }

        public override string ToString()
        {
            return string.Format("{0}", Descricao);
        }
    }
}
