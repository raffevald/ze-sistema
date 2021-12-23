namespace zeSistema.regraDeNegocio.receitas.categorias
{
    partial class ExcluirCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvListagemDados = new System.Windows.Forms.DataGridView();
            this.btCancelar = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.btConfirmarEsclusao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListagemDados
            // 
            this.dgvListagemDados.AllowUserToAddRows = false;
            this.dgvListagemDados.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dgvListagemDados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListagemDados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListagemDados.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListagemDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListagemDados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListagemDados.Enabled = false;
            this.dgvListagemDados.Location = new System.Drawing.Point(110, 160);
            this.dgvListagemDados.Name = "dgvListagemDados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagemDados.RowTemplate.Height = 25;
            this.dgvListagemDados.Size = new System.Drawing.Size(896, 311);
            this.dgvListagemDados.TabIndex = 41;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(591, 112);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(415, 34);
            this.btCancelar.TabIndex = 40;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodigo.Location = new System.Drawing.Point(204, 48);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(291, 31);
            this.tbCodigo.TabIndex = 37;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.Location = new System.Drawing.Point(110, 51);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(71, 25);
            this.lbCodigo.TabIndex = 36;
            this.lbCodigo.Text = "Codigo";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateTime.Location = new System.Drawing.Point(664, 45);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(342, 31);
            this.dtpDateTime.TabIndex = 35;
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataDeCadastro.Location = new System.Drawing.Point(511, 48);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(147, 25);
            this.lbDataDeCadastro.TabIndex = 34;
            this.lbDataDeCadastro.Text = "Data de cadastro";
            // 
            // btConfirmarEsclusao
            // 
            this.btConfirmarEsclusao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConfirmarEsclusao.Location = new System.Drawing.Point(110, 112);
            this.btConfirmarEsclusao.Name = "btConfirmarEsclusao";
            this.btConfirmarEsclusao.Size = new System.Drawing.Size(415, 34);
            this.btConfirmarEsclusao.TabIndex = 33;
            this.btConfirmarEsclusao.Text = "Confirmar exclusão";
            this.btConfirmarEsclusao.UseVisualStyleBackColor = true;
            this.btConfirmarEsclusao.Click += new System.EventHandler(this.btConfirmarEsclusao_Click);
            // 
            // ExcluirCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 564);
            this.Controls.Add(this.dgvListagemDados);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.lbDataDeCadastro);
            this.Controls.Add(this.btConfirmarEsclusao);
            this.Name = "ExcluirCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExcluirCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListagemDados;
        private Button btCancelar;
        private TextBox tbCodigo;
        private Label lbCodigo;
        private DateTimePicker dtpDateTime;
        private Label lbDataDeCadastro;
        private Button btConfirmarEsclusao;
    }
}