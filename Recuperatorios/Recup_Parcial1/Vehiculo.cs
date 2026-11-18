using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial1 {
    public abstract class Vehiculo {
        public int patente { get; set; }
        public string marca { get; set; }
        public int hora { get; set; }
        public string tipo { get; set; }
        public abstract decimal CalcularCobro();
    }
}
