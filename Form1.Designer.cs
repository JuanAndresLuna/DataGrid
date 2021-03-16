
namespace DataGrid
{
    partial class Form1
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
            this.btnGrilla2 = new System.Windows.Forms.Button();
            this.btnExcel2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrilla2
            // 
            this.btnGrilla2.Location = new System.Drawing.Point(82, 396);
            this.btnGrilla2.Name = "btnGrilla2";
            this.btnGrilla2.Size = new System.Drawing.Size(272, 70);
            this.btnGrilla2.TabIndex = 0;
            this.btnGrilla2.Text = "LLenar Grilla";
            this.btnGrilla2.UseVisualStyleBackColor = true;
            this.btnGrilla2.Click += new System.EventHandler(this.btnGrilla2_Click);
            // 
            // btnExcel2
            // 
            this.btnExcel2.Location = new System.Drawing.Point(575, 396);
            this.btnExcel2.Name = "btnExcel2";
            this.btnExcel2.Size = new System.Drawing.Size(272, 70);
            this.btnExcel2.TabIndex = 1;
            this.btnExcel2.Text = "Exportar a Excel";
            this.btnExcel2.UseVisualStyleBackColor = true;
            this.btnExcel2.Click += new System.EventHandler(this.btnExcel2_Click_1);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 342);
            this.dataGridView1.TabIndex = 2;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1009, 510);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnExcel2);
            this.Controls.Add(this.btnGrilla2);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaDatos;
        private System.Windows.Forms.Button btnGrilla;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulos;
        private System.Windows.Forms.Button btnGrilla2;
        private System.Windows.Forms.Button btnExcel2;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

