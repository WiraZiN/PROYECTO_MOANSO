namespace PROYECTO_MOANSO
{
    partial class MantenedorPrenda
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.dgvMaterialPrenda = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbkestMaterial = new System.Windows.Forms.CheckBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtMaterialPrenda = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPrenda)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(478, 23);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(91, 50);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(478, 97);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(91, 50);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(478, 176);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(91, 50);
            this.btnDeshabilitar.TabIndex = 2;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // dgvMaterialPrenda
            // 
            this.dgvMaterialPrenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterialPrenda.Location = new System.Drawing.Point(24, 23);
            this.dgvMaterialPrenda.Name = "dgvMaterialPrenda";
            this.dgvMaterialPrenda.Size = new System.Drawing.Size(406, 203);
            this.dgvMaterialPrenda.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 258);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Tipo de Material:";
            // 
            // cbkestMaterial
            // 
            this.cbkestMaterial.AutoSize = true;
            this.cbkestMaterial.Location = new System.Drawing.Point(341, 258);
            this.cbkestMaterial.Name = "cbkestMaterial";
            this.cbkestMaterial.Size = new System.Drawing.Size(99, 17);
            this.cbkestMaterial.TabIndex = 6;
            this.cbkestMaterial.Text = "Estado Material";
            this.cbkestMaterial.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(51, 255);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(28, 20);
            this.txtID.TabIndex = 7;
            // 
            // txtMaterialPrenda
            // 
            this.txtMaterialPrenda.Location = new System.Drawing.Point(114, 299);
            this.txtMaterialPrenda.Name = "txtMaterialPrenda";
            this.txtMaterialPrenda.Size = new System.Drawing.Size(156, 20);
            this.txtMaterialPrenda.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 365);
            this.Controls.Add(this.txtMaterialPrenda);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.cbkestMaterial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvMaterialPrenda);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Name = "Form1";
            this.Text = "Mantenedor Prenda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterialPrenda)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.DataGridView dgvMaterialPrenda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbkestMaterial;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtMaterialPrenda;
    }
}

