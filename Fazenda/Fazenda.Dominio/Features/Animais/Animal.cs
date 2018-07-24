using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fazenda.Dominio.Features.Animais
{
    public class Animal
    {
        public int Id { get; set; }
        public string Especie { get; set; }

        public void Validar()
        {
            if (string.IsNullOrEmpty(Especie)) throw new AnimalEspecieVaziaExcecao();
        }

        public override string ToString()
        {
            return string.Format("{0}", Especie);
        }
    }
}
