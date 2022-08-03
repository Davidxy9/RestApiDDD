using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestApiDDD.Domain.Entitys
{
    public class Produto : Base
    {
        public string Nome { get; set; }

        public decimal Valor { get; set; }

        public bool IsDisponivel { get; set; }
    }
}
