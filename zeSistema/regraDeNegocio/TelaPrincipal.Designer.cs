namespace zeSistema.regraDeNegocio
{
    partial class TelaPrincipal
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
            this.btReceitas = new System.Windows.Forms.Button();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.btCategoriaReceitas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btReceitas
            // 
            this.btReceitas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReceitas.Location = new System.Drawing.Point(45, 82);
            this.btReceitas.Name = "btReceitas";
            this.btReceitas.Size = new System.Drawing.Size(236, 46);
            this.btReceitas.TabIndex = 7;
            this.btReceitas.Text = "Receitas";
            this.btReceitas.UseVisualStyleBackColor = true;
            this.btReceitas.Click += new System.EventHandler(this.btReceitas_Click);
            // 
            // tbNome
            // 
            this.tbNome.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbNome.Location = new System.Drawing.Point(1031, 1);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(231, 31);
            this.tbNome.TabIndex = 8;
            // 
            // btCategoriaReceitas
            // 
            this.btCategoriaReceitas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCategoriaReceitas.Location = new System.Drawing.Point(45, 143);
            this.btCategoriaReceitas.Name = "btCategoriaReceitas";
            this.btCategoriaReceitas.Size = new System.Drawing.Size(236, 46);
            this.btCategoriaReceitas.TabIndex = 9;
            this.btCategoriaReceitas.Text = "Categoria receitas";
            this.btCategoriaReceitas.UseVisualStyleBackColor = true;
            this.btCategoriaReceitas.Click += new System.EventHandler(this.btCategoriaReceitas_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btCategoriaReceitas);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.btReceitas);
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaPrincipal";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btReceitas;
        private TextBox tbNome;
        private Button btCategoriaReceitas;
    }
}