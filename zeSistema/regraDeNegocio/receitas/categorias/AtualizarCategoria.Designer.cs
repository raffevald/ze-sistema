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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.btConfirmarAtualizacao = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDeCategoria = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.dgvListagemDados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateTime.Location = new System.Drawing.Point(748, 65);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(342, 31);
            this.dtpDateTime.TabIndex = 22;
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataDeCadastro.Location = new System.Drawing.Point(595, 68);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(147, 25);
            this.lbDataDeCadastro.TabIndex = 21;
            this.lbDataDeCadastro.Text = "Data de cadastro";
            // 
            // btConfirmarAtualizacao
            // 
            this.btConfirmarAtualizacao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btConfirmarAtualizacao.Location = new System.Drawing.Point(194, 180);
            this.btConfirmarAtualizacao.Name = "btConfirmarAtualizacao";
            this.btConfirmarAtualizacao.Size = new System.Drawing.Size(415, 34);
            this.btConfirmarAtualizacao.TabIndex = 20;
            this.btConfirmarAtualizacao.Text = "Confirmar atualização";
            this.btConfirmarAtualizacao.UseVisualStyleBackColor = true;
            this.btConfirmarAtualizacao.Click += new System.EventHandler(this.btConfirmarAtualizacao_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricao.Location = new System.Drawing.Point(288, 116);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(291, 31);
            this.tbDescricao.TabIndex = 19;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(194, 119);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(88, 25);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "Descrição";
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodigo.Location = new System.Drawing.Point(288, 68);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(291, 31);
            this.tbCodigo.TabIndex = 26;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.Location = new System.Drawing.Point(194, 71);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(71, 25);
            this.lbCodigo.TabIndex = 25;
            this.lbCodigo.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(595, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tipo de categoria";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbTipoDeCategoria
            // 
            this.cbTipoDeCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoDeCategoria.FormattingEnabled = true;
            this.cbTipoDeCategoria.Items.AddRange(new object[] {
            "Recebimentos",
            "Despesas"});
            this.cbTipoDeCategoria.Location = new System.Drawing.Point(748, 113);
            this.cbTipoDeCategoria.Name = "cbTipoDeCategoria";
            this.cbTipoDeCategoria.Size = new System.Drawing.Size(342, 31);
            this.cbTipoDeCategoria.TabIndex = 27;
            this.cbTipoDeCategoria.SelectedIndexChanged += new System.EventHandler(this.cbTipoDeCategoria_SelectedIndexChanged);
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(675, 180);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(415, 34);
            this.btCancelar.TabIndex = 29;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
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
            this.dgvListagemDados.Location = new System.Drawing.Point(194, 228);
            this.dgvListagemDados.Name = "dgvListagemDados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagemDados.RowTemplate.Height = 25;
            this.dgvListagemDados.Size = new System.Drawing.Size(896, 311);
            this.dgvListagemDados.TabIndex = 30;
            this.dgvListagemDados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListagemDados_CellContentClick);
            // 
            // AtualizarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 589);
            this.Controls.Add(this.dgvListagemDados);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoDeCategoria);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.lbDataDeCadastro);
            this.Controls.Add(this.btConfirmarAtualizacao);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Name = "AtualizarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AtualizarCategoria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDateTime;
        private Label lbDataDeCadastro;
        private Button btConfirmarAtualizacao;
        private TextBox tbDescricao;
        private Label lbDescricao;
        private TextBox tbCodigo;
        private Label lbCodigo;
        private Label label1;
        private ComboBox cbTipoDeCategoria;
        private Button btCancelar;
        private DataGridView dgvListagemDados;
    }
}