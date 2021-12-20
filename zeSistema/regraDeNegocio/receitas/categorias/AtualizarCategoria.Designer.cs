namespace zeSistema.regraDeNegocio.receitas.categorias
{
    partial class AtualizarCategoria
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
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.btCadastrarCategoria = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateTime.Location = new System.Drawing.Point(626, 51);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(342, 31);
            this.dtpDateTime.TabIndex = 22;
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataDeCadastro.Location = new System.Drawing.Point(473, 54);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(147, 25);
            this.lbDataDeCadastro.TabIndex = 21;
            this.lbDataDeCadastro.Text = "Data de cadastro";
            // 
            // btCadastrarCategoria
            // 
            this.btCadastrarCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadastrarCategoria.Location = new System.Drawing.Point(745, 99);
            this.btCadastrarCategoria.Name = "btCadastrarCategoria";
            this.btCadastrarCategoria.Size = new System.Drawing.Size(223, 34);
            this.btCadastrarCategoria.TabIndex = 20;
            this.btCadastrarCategoria.Text = "Cadastrar categoria";
            this.btCadastrarCategoria.UseVisualStyleBackColor = true;
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricao.Location = new System.Drawing.Point(167, 51);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(291, 31);
            this.tbDescricao.TabIndex = 19;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(73, 54);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(88, 25);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "Descrição";
            // 
            // AtualizarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 257);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.lbDataDeCadastro);
            this.Controls.Add(this.btCadastrarCategoria);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Name = "AtualizarCategoria";
            this.Text = "AtualizarCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDateTime;
        private Label lbDataDeCadastro;
        private Button btCadastrarCategoria;
        private TextBox tbDescricao;
        private Label lbDescricao;
    }
}