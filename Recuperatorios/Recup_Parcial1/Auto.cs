using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial1 {
    public class Auto : Vehiculo {
        
        public Auto(int patente, string marca, int hora) {
            this.patente = patente;
            this.marca = marca;
            this.hora = hora;
            this.tipo = "Auto";
        }
        public override decimal CalcularCobro() {
            return hora * 1000;
        }
    }
}
