using Recuperatorios.Recup_Parcial2;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperatorios.Recup.Parcial1 {
    public partial class Form_RecupParcial2 : Form {
        public Form_RecupParcial2() {
            InitializeComponent();
            CargarDataGrid();


        }

        public Conexion con = new Conexion();

        private void btnAgregar_Click(object sender, EventArgs e) {

        }
        private void CargarDataGrid() {
            Perfume perfume = new Perfume();
            ArrayList perfumes = perfume.Obtener();
            dgvPerfumes.Rows.Clear();
            foreach (Perfume p in perfumes) {
                dgvPerfumes.Rows.Add( p.Nombre, p.Marca, p.Precio, p.Stock);
            }
           
        }
        
    }
}
