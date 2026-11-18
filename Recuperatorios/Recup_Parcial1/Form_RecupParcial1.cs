using Recuperatorios.Recup_Parcial1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recuperatorios.Recup.Parcial1 {
    public partial class Form_RecupParcial1 : Form {
        public Form_RecupParcial1() {
            InitializeComponent();
        }
        Vehiculo[] lugares = new Vehiculo[10];

        private void btnIngresar_Click(object sender, EventArgs e) {
            if (cmbTipo.SelectedIndex != 0) {
                switch (cmbTipo.Text) {
                    case "Auto":
                        Auto auto = new Auto(int.Parse(txtPatente.Text), txtMarca.Text, int.Parse(txtHoras.Text));
                        lugares[ObtenerUltimaPosicion()] = auto;
                        CargarDataGridView();
                        break;
                    case "Moto":
                        Moto moto = new Moto(int.Parse(txtPatente.Text), txtMarca.Text, int.Parse(txtHoras.Text));
                        lugares[ObtenerUltimaPosicion()] = moto;
                        CargarDataGridView();
                        break;
                    case "Camioneta":
                        Camioneta camioneta = new Camioneta(int.Parse(txtPatente.Text), txtMarca.Text, int.Parse(txtHoras.Text));
                        lugares[ObtenerUltimaPosicion()] = camioneta;
                        CargarDataGridView();
                        break;
                }
            }
        }
        private void CargarDataGridView() {
            dgvVehiculos.Rows.Clear();

            int indexer = 0;
            foreach (Vehiculo vehiculo in lugares) {
                if (vehiculo != null) {
                    dgvVehiculos.Rows.Add(indexer, vehiculo.patente, vehiculo.marca, vehiculo.tipo, vehiculo.hora, vehiculo.CalcularCobro());
                    indexer++;
                }
            }
        }
        private void CargarComboBox() {
            cmbTipo.Items.Insert(0,"Seleccionar tipo");
            cmbTipo.Items.Insert(1, "Auto");
            cmbTipo.Items.Insert(2, "Moto");
            cmbTipo.Items.Insert(3, "Camioneta");

            cmbTipo.SelectedIndex = 0;
        }

        private int ObtenerUltimaPosicion() {
            int posicion = -1;

            for (int i = 0; i < lugares.Length; i++) {
                if (lugares[i] == null) {
                    posicion = i;
                    break;
                }
            }
            return posicion;
        }

        private void Form_RecupParcial1_Shown(object sender, EventArgs e) {
            CargarComboBox();
            CargarDataGridView();
        }
    }
}
