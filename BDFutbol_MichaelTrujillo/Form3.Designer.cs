
namespace BDFutbol_MichaelTrujillo
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codcontratoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coddnionieDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.futbolistasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codEquipoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.equiposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fechaInicioDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioanualDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciorecisionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coddnionieDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.codEquipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fechaInicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaFinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioanualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciorecisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.equiposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.futbolistasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contratosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.contratosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolistasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codcontratoDataGridViewTextBoxColumn,
            this.coddnionieDataGridViewTextBoxColumn1,
            this.codEquipoDataGridViewTextBoxColumn1,
            this.fechaInicioDataGridViewTextBoxColumn1,
            this.fechaFinDataGridViewTextBoxColumn1,
            this.precioanualDataGridViewTextBoxColumn1,
            this.preciorecisionDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.contratosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-5, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // codcontratoDataGridViewTextBoxColumn
            // 
            this.codcontratoDataGridViewTextBoxColumn.DataPropertyName = "codcontrato";
            this.codcontratoDataGridViewTextBoxColumn.HeaderText = "codcontrato";
            this.codcontratoDataGridViewTextBoxColumn.Name = "codcontratoDataGridViewTextBoxColumn";
            // 
            // coddnionieDataGridViewTextBoxColumn1
            // 
            this.coddnionieDataGridViewTextBoxColumn1.DataPropertyName = "coddnionie";
            this.coddnionieDataGridViewTextBoxColumn1.DataSource = this.futbolistasBindingSource;
            this.coddnionieDataGridViewTextBoxColumn1.DisplayMember = "nombre";
            this.coddnionieDataGridViewTextBoxColumn1.HeaderText = "coddnionie";
            this.coddnionieDataGridViewTextBoxColumn1.Name = "coddnionieDataGridViewTextBoxColumn1";
            this.coddnionieDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coddnionieDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.coddnionieDataGridViewTextBoxColumn1.ValueMember = "coddnionie";
            // 
            // futbolistasBindingSource
            // 
            this.futbolistasBindingSource.DataSource = typeof(BDFutbol_MichaelTrujillo.futbolistas);
            // 
            // codEquipoDataGridViewTextBoxColumn1
            // 
            this.codEquipoDataGridViewTextBoxColumn1.DataPropertyName = "codEquipo";
            this.codEquipoDataGridViewTextBoxColumn1.DataSource = this.equiposBindingSource;
            this.codEquipoDataGridViewTextBoxColumn1.DisplayMember = "nomEquipo";
            this.codEquipoDataGridViewTextBoxColumn1.HeaderText = "codEquipo";
            this.codEquipoDataGridViewTextBoxColumn1.Name = "codEquipoDataGridViewTextBoxColumn1";
            this.codEquipoDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codEquipoDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codEquipoDataGridViewTextBoxColumn1.ValueMember = "codEquipo";
            // 
            // equiposBindingSource
            // 
            this.equiposBindingSource.DataSource = typeof(BDFutbol_MichaelTrujillo.equipos);
            // 
            // fechaInicioDataGridViewTextBoxColumn1
            // 
            this.fechaInicioDataGridViewTextBoxColumn1.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn1.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn1.Name = "fechaInicioDataGridViewTextBoxColumn1";
            // 
            // fechaFinDataGridViewTextBoxColumn1
            // 
            this.fechaFinDataGridViewTextBoxColumn1.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn1.HeaderText = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn1.Name = "fechaFinDataGridViewTextBoxColumn1";
            // 
            // precioanualDataGridViewTextBoxColumn1
            // 
            this.precioanualDataGridViewTextBoxColumn1.DataPropertyName = "precioanual";
            this.precioanualDataGridViewTextBoxColumn1.HeaderText = "precioanual";
            this.precioanualDataGridViewTextBoxColumn1.Name = "precioanualDataGridViewTextBoxColumn1";
            // 
            // preciorecisionDataGridViewTextBoxColumn1
            // 
            this.preciorecisionDataGridViewTextBoxColumn1.DataPropertyName = "preciorecision";
            this.preciorecisionDataGridViewTextBoxColumn1.HeaderText = "preciorecision";
            this.preciorecisionDataGridViewTextBoxColumn1.Name = "preciorecisionDataGridViewTextBoxColumn1";
            // 
            // contratosBindingSource
            // 
            this.contratosBindingSource.DataSource = typeof(BDFutbol_MichaelTrujillo.contratos);
            // 
            // coddnionieDataGridViewTextBoxColumn
            // 
            this.coddnionieDataGridViewTextBoxColumn.DataPropertyName = "coddnionie";
            this.coddnionieDataGridViewTextBoxColumn.DataSource = this.futbolistasBindingSource;
            this.coddnionieDataGridViewTextBoxColumn.DisplayMember = "coddnionie";
            this.coddnionieDataGridViewTextBoxColumn.HeaderText = "coddnionie";
            this.coddnionieDataGridViewTextBoxColumn.Name = "coddnionieDataGridViewTextBoxColumn";
            this.coddnionieDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.coddnionieDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // codEquipoDataGridViewTextBoxColumn
            // 
            this.codEquipoDataGridViewTextBoxColumn.DataPropertyName = "codEquipo";
            this.codEquipoDataGridViewTextBoxColumn.DataSource = this.equiposBindingSource;
            this.codEquipoDataGridViewTextBoxColumn.DisplayMember = "nomEquipo";
            this.codEquipoDataGridViewTextBoxColumn.HeaderText = "codEquipo";
            this.codEquipoDataGridViewTextBoxColumn.Name = "codEquipoDataGridViewTextBoxColumn";
            this.codEquipoDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.codEquipoDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.codEquipoDataGridViewTextBoxColumn.ValueMember = "codEquipo";
            // 
            // fechaInicioDataGridViewTextBoxColumn
            // 
            this.fechaInicioDataGridViewTextBoxColumn.DataPropertyName = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.HeaderText = "fechaInicio";
            this.fechaInicioDataGridViewTextBoxColumn.Name = "fechaInicioDataGridViewTextBoxColumn";
            // 
            // fechaFinDataGridViewTextBoxColumn
            // 
            this.fechaFinDataGridViewTextBoxColumn.DataPropertyName = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.HeaderText = "fechaFin";
            this.fechaFinDataGridViewTextBoxColumn.Name = "fechaFinDataGridViewTextBoxColumn";
            // 
            // precioanualDataGridViewTextBoxColumn
            // 
            this.precioanualDataGridViewTextBoxColumn.DataPropertyName = "precioanual";
            this.precioanualDataGridViewTextBoxColumn.HeaderText = "precioanual";
            this.precioanualDataGridViewTextBoxColumn.Name = "precioanualDataGridViewTextBoxColumn";
            // 
            // preciorecisionDataGridViewTextBoxColumn
            // 
            this.preciorecisionDataGridViewTextBoxColumn.DataPropertyName = "preciorecision";
            this.preciorecisionDataGridViewTextBoxColumn.HeaderText = "preciorecision";
            this.preciorecisionDataGridViewTextBoxColumn.Name = "preciorecisionDataGridViewTextBoxColumn";
            // 
            // equiposDataGridViewTextBoxColumn
            // 
            this.equiposDataGridViewTextBoxColumn.DataPropertyName = "equipos";
            this.equiposDataGridViewTextBoxColumn.HeaderText = "equipos";
            this.equiposDataGridViewTextBoxColumn.Name = "equiposDataGridViewTextBoxColumn";
            // 
            // futbolistasDataGridViewTextBoxColumn
            // 
            this.futbolistasDataGridViewTextBoxColumn.DataPropertyName = "futbolistas";
            this.futbolistasDataGridViewTextBoxColumn.HeaderText = "futbolistas";
            this.futbolistasDataGridViewTextBoxColumn.Name = "futbolistasDataGridViewTextBoxColumn";
            // 
            // contratosBindingSource2
            // 
            this.contratosBindingSource2.DataSource = typeof(BDFutbol_MichaelTrujillo.contratos);
            // 
            // contratosBindingSource1
            // 
            this.contratosBindingSource1.DataSource = typeof(BDFutbol_MichaelTrujillo.contratos);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Michael Jonay Trujillo Padilla";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.futbolistasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equiposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratosBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource contratosBindingSource1;
        private System.Windows.Forms.BindingSource contratosBindingSource2;
        private System.Windows.Forms.BindingSource contratosBindingSource;
        private System.Windows.Forms.BindingSource equiposBindingSource;
        private System.Windows.Forms.BindingSource futbolistasBindingSource;
        private System.Windows.Forms.DataGridViewComboBoxColumn coddnionieDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn codEquipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioanualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciorecisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn equiposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn futbolistasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codcontratoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn coddnionieDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn codEquipoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaInicioDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaFinDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioanualDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciorecisionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label1;
    }
}