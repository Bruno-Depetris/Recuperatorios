namespace Recuperatorios.Parcial_Integrador {
    partial class Form_Estadisticas {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && ( components != null )) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvDias = new System.Windows.Forms.DataGridView();
            this.colDia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDiaMax = new System.Windows.Forms.Label();
            ( (System.ComponentModel.ISupportInitialize)( this.dgvDias ) ).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.Location = new System.Drawing.Point(20, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Ingresos por día de la semana";
            // 
            // dgvDias
            // 
            this.dgvDias.AllowUserToAddRows = false;
            this.dgvDias.AllowUserToDeleteRows = false;
            this.dgvDias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDia,
            this.colCantidad});
            this.dgvDias.MultiSelect = false;
            this.dgvDias.ReadOnly = true;
            this.dgvDias.RowHeadersVisible = false;
            this.dgvDias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDias.Location = new System.Drawing.Point(20, 50);
            this.dgvDias.Name = "dgvDias";
            this.dgvDias.Size = new System.Drawing.Size(380, 230);
            this.dgvDias.TabIndex = 1;
            // 
            // lblDiaMax
            // 
            this.lblDiaMax.AutoSize = true;
            this.lblDiaMax.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblDiaMax.Location = new System.Drawing.Point(20, 300);
            this.lblDiaMax.Name = "lblDiaMax";
            this.lblDiaMax.TabIndex = 2;
            this.lblDiaMax.Text = "Día con más ingresos: -";
            // 
            // colDia
            // 
            this.colDia.FillWeight = 120F;
            this.colDia.HeaderText = "Día";
            this.colDia.Name = "colDia";
            this.colDia.ReadOnly = true;
            // 
            // colCantidad
            // 
            this.colCantidad.FillWeight = 80F;
            this.colCantidad.HeaderText = "Ingresos";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            // 
            // Form_Estadisticas
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 360);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvDias);
            this.Controls.Add(this.lblDiaMax);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadísticas de ingresos";
            ( (System.ComponentModel.ISupportInitialize)( this.dgvDias ) ).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.DataGridView dgvDias;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDia;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.Label lblDiaMax;
    }
}
