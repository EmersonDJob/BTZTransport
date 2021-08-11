using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTZTransport.Models
{
    public class Abastecimento
    {
        public virtual Veiculo VeiculoId { get; set; }
        public virtual Motorista MotoristaId { get; set; }
        public DateTime Data { get; set; }
        public TipoCombustivel tipo { get; set; }
        public double QuantidadeCombustivel { get; set; }

        public float Calcular(TipoCombustivel tipo, double QuantidadeCombustivel)
        {
            var total = 0.0;

           switch (tipo)
            {
                case TipoCombustivel.Gasolina:
                   total = (float)(QuantidadeCombustivel * 4.29);
                    break;
                case TipoCombustivel.Etanol:
                    total = (float)(QuantidadeCombustivel * 2.99);
                    break;
                case TipoCombustivel.Diesel:
                   total = (float)(QuantidadeCombustivel * 2.09);
                    break;
            }
            return (float)total;

        }
    }
}
