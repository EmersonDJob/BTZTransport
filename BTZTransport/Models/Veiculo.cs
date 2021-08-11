using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransport.Models
{
    public class Veiculo
    {
        public int VeiculoId { get; set; }
        public string Placa { get; set; }
        public string NomeVeiculo { get; set; }
        public TipoCombustivel tipo { get; set; }
        public string Fabricante { get; set; }
        public DateTime AnoFabricaco { get; set; }
        public float MaxTanque { get; set; }


    }
}
