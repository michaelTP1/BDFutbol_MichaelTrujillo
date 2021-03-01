
namespace BDFutbol_MichaelTrujillo
{
    partial class Form2
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.showEquiposButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showFutbolistasButton = new System.Windows.Forms.Button();
            this.showLigasButton = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filasLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // showEquiposButton
            // 
            this.showEquiposButton.Location = new System.Drawing.Point(12, 40);
            this.showEquiposButton.Name = "showEquiposButton";
            this.showEquiposButton.Size = new System.Drawing.Size(89, 28);
            this.showEquiposButton.TabIndex = 0;
            this.showEquiposButton.Text = "ver equipos";
            this.showEquiposButton.UseVisualStyleBackColor = true;
            this.showEquiposButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(107, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1064, 497);
            this.dataGridView1.TabIndex = 1;
            // 
            // showFutbolistasButton
            // 
            this.showFutbolistasButton.Location = new System.Drawing.Point(12, 131);
            this.showFutbolistasButton.Name = "showFutbolistasButton";
            this.showFutbolistasButton.Size = new System.Drawing.Size(89, 28);
            this.showFutbolistasButton.TabIndex = 3;
            this.showFutbolistasButton.Text = "futbolistas";
            this.showFutbolistasButton.UseVisualStyleBackColor = true;
            this.showFutbolistasButton.Click += new System.EventHandler(this.showFutbolistasButton_Click);
            // 
            // showLigasButton
            // 
            this.showLigasButton.Location = new System.Drawing.Point(12, 176);
            this.showLigasButton.Name = "showLigasButton";
            this.showLigasButton.Size = new System.Drawing.Size(89, 28);
            this.showLigasButton.TabIndex = 4;
            this.showLigasButton.Text = "ligas";
            this.showLigasButton.UseVisualStyleBackColor = true;
            this.showLigasButton.Click += new System.EventHandler(this.showLigasButton_Click);
            // 
            // Actualizar
            // 
            this.Actualizar.Location = new System.Drawing.Point(12, 309);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(89, 28);
            this.Actualizar.TabIndex = 6;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.Actualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(561, 531);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Michael Jonay Trujillo Padilla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 429);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Filas: ";
            // 
            // filasLabel
            // 
            this.filasLabel.AutoSize = true;
            this.filasLabel.Location = new System.Drawing.Point(40, 429);
            this.filasLabel.Name = "filasLabel";
            this.filasLabel.Size = new System.Drawing.Size(0, 13);
            this.filasLabel.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "ver contratos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.filasLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.showLigasButton);
            this.Controls.Add(this.showFutbolistasButton);
            this.Controls.Add(this.showEquiposButton);
            this.Name = "Form2";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showEquiposButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showFutbolistasButton;
        private System.Windows.Forms.Button showLigasButton;
        private System.Windows.Forms.Button Actualizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label filasLabel;
        private System.Windows.Forms.Button button1;
    }
}

