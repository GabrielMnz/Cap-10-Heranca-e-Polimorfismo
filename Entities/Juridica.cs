using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities {
    internal class Juridica : Contribuinte {
        public int NFuncionarios { get; set; }
        public Juridica(string name, double rendaAnual, int nfuncionarios)
            : base(name, rendaAnual) {
            NFuncionarios = nfuncionarios;
        }
        public override double Imposto() {
            if (NFuncionarios <= 10) {
                return RendaAnual * 0.16;
            }
            else {
                return RendaAnual * 0.14;
            }
        }
    }
}
