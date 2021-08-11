using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransport.Models
{
    public class Motorista
    {
        public int MotoristaId { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CNH { get; set; }
        public string Categoria { get; set; }
        public DateTime DataNascimento { get; set; }

        public bool Status { get; set; }
    }
}
