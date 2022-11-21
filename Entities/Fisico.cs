using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities {
    internal class Fisico : Contribuinte {
        public double GastoSaude { get; set; }

        public Fisico(string name, double rendaAnual, double gastoSaude)
            : base(name, rendaAnual) {
            GastoSaude = gastoSaude;
        }

        public override double Imposto() {
            if (RendaAnual > 20000) {
                return (RendaAnual - 20000) * 0.25 + (20000 * 0.15) - (GastoSaude * 0.5);
            }
            else {
                return RendaAnual * 0.15 - (GastoSaude * 0.5);
            }
        }
    }
}
