using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial1 {
    public class Camioneta : Vehiculo {
        public Camioneta(int patente, string marca, int hora) {
            this.patente = patente;
            this.marca = marca;
            this.hora = hora;
            this.tipo = "Camioneta";
        }
        public override decimal CalcularCobro() {
            return hora * 1500;
        }
    }
}
