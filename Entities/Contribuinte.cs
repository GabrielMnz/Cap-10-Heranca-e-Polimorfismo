using System.Globalization;
using Primeiro.Entities.Enums;

namespace Primeiro.Entities {
    abstract class Contribuinte {
        public string Name { get; set; }
        public double RendaAnual { get; set; }

        public Contribuinte(string name, double rendaAnual) {
        Name = name;
        RendaAnual = rendaAnual;
        }

        public abstract double Imposto();

    }
}
