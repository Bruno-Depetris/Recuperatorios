using Recuperatorios.Recup.Parcial1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Recuperatorios.Recup_Parcial2 {
    public class Perfume {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }

       

        public bool Alta(Perfume perfume) {
            Form_RecupParcial2 form = new Form_RecupParcial2();
             if (form.con.Ejecutar(Consultas.InsertarPerfume(perfume))) {
                return true;
            }
            return false;
        }
        public bool Modificar(Perfume perfume) {
            Form_RecupParcial2 form = new Form_RecupParcial2();
            if (form.con.Ejecutar(Consultas.ActualizarPerfume(perfume))) {
                return true;
            }
            return false;
        }
        public bool Baja(int id) {
            Form_RecupParcial2 form = new Form_RecupParcial2();
            if (form.con.Ejecutar(Consultas.EliminarPerfume(id))) {
                return true;
            }
            return false;
        }

        public ArrayList Obtener() {
            Form_RecupParcial2 form = new Form_RecupParcial2();
            
            ArrayList perfumes = new ArrayList();

            SqlDataReader lector = form.con.Leer(Consultas.ObtenerPerfumes());
            while (lector.Read()) {
                Perfume perfume = new Perfume {
                    Id = Convert.ToInt32(lector["Id"]),
                    Nombre = lector["Nombre"].ToString(),
                    Marca = lector["Marca"].ToString(),
                    Precio = Convert.ToDecimal(lector["Precio"]),
                    Stock = Convert.ToInt32(lector["Stock"])
                };
                perfumes.Add(perfume);
            }
            return perfumes;
        }

        public Perfume ObtenerUno() {
            Form_RecupParcial2 form = new Form_RecupParcial2();
            SqlDataReader lector = form.con.Leer(Consultas.ObtenerPerfumePorId(this.Id));
            if (lector.Read()) {
                this.Nombre = lector["Nombre"].ToString();
                this.Marca = lector["Marca"].ToString();
                this.Precio = Convert.ToDecimal(lector["Precio"]);
                this.Stock = Convert.ToInt32(lector["Stock"]);
            }
            return this;
        }
    }
}
