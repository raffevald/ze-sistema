namespace zeSistema.regraDeNegocio.receitas
{
    partial class ReceitasZe
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
            this.btCategoriaReceitas = new System.Windows.Forms.Button();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.btTrocarDeUsuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCategoriaReceitas
            // 
            this.btCategoriaReceitas.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCategoriaReceitas.Location = new System.Drawing.Point(53, 50);
            this.btCategoriaReceitas.Name = "btCategoriaReceitas";
            this.btCategoriaReceitas.Size = new System.Drawing.Size(236, 46);
            this.btCategoriaReceitas.TabIndex = 10;
            this.btCategoriaReceitas.Text = "Categoria receitas";
            this.btCategoriaReceitas.UseVisualStyleBackColor = true;
            this.btCategoriaReceitas.Click += new System.EventHandler(this.btCategoriaReceitas_Click);
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(849, 625);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(186, 34);
            this.btVoltarTelaPrincipal.TabIndex = 11;
            this.btVoltarTelaPrincipal.Text = "Voltar a tela principal";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // btTrocarDeUsuario
            // 
            this.btTrocarDeUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTrocarDeUsuario.Location = new System.Drawing.Point(1069, 625);
            this.btTrocarDeUsuario.Name = "btTrocarDeUsuario";
            this.btTrocarDeUsuario.Size = new System.Drawing.Size(162, 34);
            this.btTrocarDeUsuario.TabIndex = 12;
            this.btTrocarDeUsuario.Text = "Trocar de usuario";
            this.btTrocarDeUsuario.UseVisualStyleBackColor = true;
            this.btTrocarDeUsuario.Click += new System.EventHandler(this.btTrocarDeUsuario_Click);
            // 
            // ReceitasZe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btTrocarDeUsuario);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.btCategoriaReceitas);
            this.Name = "ReceitasZe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReceitasZe";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btCategoriaReceitas;
        private Button btVoltarTelaPrincipal;
        private Button btTrocarDeUsuario;
    }
}