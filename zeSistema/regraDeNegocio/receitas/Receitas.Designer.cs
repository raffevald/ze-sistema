namespace zeSistema.regraDeNegocio.receitas
{
    partial class Receitas
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
            this.dgvListagemDados = new System.Windows.Forms.DataGridView();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.btCadastrarCategoria = new System.Windows.Forms.Button();
            this.tbValor = new System.Windows.Forms.TextBox();
            this.lbValor = new System.Windows.Forms.Label();
            this.tbQTDTotalDeParcelas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbQTDTotalDeParcelasPagas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSituacaoDoRecebimento = new System.Windows.Forms.ComboBox();
            this.dateVencimento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFormaDeREcebimento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbOrigemRecebimento = new System.Windows.Forms.ComboBox();
            this.btVoltarParaReceitasZe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateTime.Location = new System.Drawing.Point(940, 30);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(342, 31);
            this.dtpDateTime.TabIndex = 22;
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
            this.dgvListagemDados.Location = new System.Drawing.Point(114, 302);
            this.dgvListagemDados.Name = "dgvListagemDados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagemDados.RowTemplate.Height = 25;
            this.dgvListagemDados.Size = new System.Drawing.Size(1168, 349);
            this.dgvListagemDados.TabIndex = 21;
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataDeCadastro.Location = new System.Drawing.Point(787, 36);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(147, 25);
            this.lbDataDeCadastro.TabIndex = 20;
            this.lbDataDeCadastro.Text = "Data de cadastro";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricao.Location = new System.Drawing.Point(328, 30);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(291, 31);
            this.tbDescricao.TabIndex = 19;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(234, 36);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(88, 25);
            this.lbDescricao.TabIndex = 18;
            this.lbDescricao.Text = "Descrição";
            // 
            // btCadastrarCategoria
            // 
            this.btCadastrarCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadastrarCategoria.Location = new System.Drawing.Point(1059, 175);
            this.btCadastrarCategoria.Name = "btCadastrarCategoria";
            this.btCadastrarCategoria.Size = new System.Drawing.Size(223, 34);
            this.btCadastrarCategoria.TabIndex = 23;
            this.btCadastrarCategoria.Text = "Cadastrar recebimento";
            this.btCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btCadastrarCategoria.Click += new System.EventHandler(this.btCadastrarCategoria_Click);
            // 
            // tbValor
            // 
            this.tbValor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbValor.Location = new System.Drawing.Point(328, 67);
            this.tbValor.Name = "tbValor";
            this.tbValor.Size = new System.Drawing.Size(291, 31);
            this.tbValor.TabIndex = 25;
            // 
            // lbValor
            // 
            this.lbValor.AutoSize = true;
            this.lbValor.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbValor.Location = new System.Drawing.Point(270, 73);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(52, 25);
            this.lbValor.TabIndex = 24;
            this.lbValor.Text = "Valor";
            // 
            // tbQTDTotalDeParcelas
            // 
            this.tbQTDTotalDeParcelas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQTDTotalDeParcelas.Location = new System.Drawing.Point(940, 67);
            this.tbQTDTotalDeParcelas.Name = "tbQTDTotalDeParcelas";
            this.tbQTDTotalDeParcelas.Size = new System.Drawing.Size(342, 31);
            this.tbQTDTotalDeParcelas.TabIndex = 27;
            this.tbQTDTotalDeParcelas.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(753, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "QTD Total de Parcelas";
            // 
            // tbQTDTotalDeParcelasPagas
            // 
            this.tbQTDTotalDeParcelasPagas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbQTDTotalDeParcelasPagas.Location = new System.Drawing.Point(940, 104);
            this.tbQTDTotalDeParcelasPagas.Name = "tbQTDTotalDeParcelasPagas";
            this.tbQTDTotalDeParcelasPagas.Size = new System.Drawing.Size(342, 31);
            this.tbQTDTotalDeParcelasPagas.TabIndex = 29;
            this.tbQTDTotalDeParcelasPagas.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(702, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 25);
            this.label2.TabIndex = 28;
            this.label2.Text = "QTD Total de Parcelas Pagas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(114, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 31;
            this.label3.Text = "Situação de recebimento";
            // 
            // cbSituacaoDoRecebimento
            // 
            this.cbSituacaoDoRecebimento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbSituacaoDoRecebimento.FormattingEnabled = true;
            this.cbSituacaoDoRecebimento.Items.AddRange(new object[] {
            "Recebido",
            "Em aberto",
            "Não recebido"});
            this.cbSituacaoDoRecebimento.Location = new System.Drawing.Point(328, 104);
            this.cbSituacaoDoRecebimento.Name = "cbSituacaoDoRecebimento";
            this.cbSituacaoDoRecebimento.Size = new System.Drawing.Size(291, 31);
            this.cbSituacaoDoRecebimento.TabIndex = 30;
            this.cbSituacaoDoRecebimento.Text = "Selecione um intem";
            // 
            // dateVencimento
            // 
            this.dateVencimento.CustomFormat = "";
            this.dateVencimento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dateVencimento.Location = new System.Drawing.Point(940, 141);
            this.dateVencimento.Name = "dateVencimento";
            this.dateVencimento.Size = new System.Drawing.Size(342, 31);
            this.dateVencimento.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(763, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 25);
            this.label4.TabIndex = 32;
            this.label4.Text = "Data de vencimento";
            // 
            // tbFormaDeREcebimento
            // 
            this.tbFormaDeREcebimento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbFormaDeREcebimento.Location = new System.Drawing.Point(328, 141);
            this.tbFormaDeREcebimento.Name = "tbFormaDeREcebimento";
            this.tbFormaDeREcebimento.Size = new System.Drawing.Size(291, 31);
            this.tbFormaDeREcebimento.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(130, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 25);
            this.label5.TabIndex = 34;
            this.label5.Text = "Forma de recebimento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(146, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 25);
            this.label6.TabIndex = 37;
            this.label6.Text = "Origem recebimento";
            // 
            // cbOrigemRecebimento
            // 
            this.cbOrigemRecebimento.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbOrigemRecebimento.FormattingEnabled = true;
            this.cbOrigemRecebimento.Location = new System.Drawing.Point(328, 178);
            this.cbOrigemRecebimento.Name = "cbOrigemRecebimento";
            this.cbOrigemRecebimento.Size = new System.Drawing.Size(291, 31);
            this.cbOrigemRecebimento.TabIndex = 36;
            this.cbOrigemRecebimento.Text = "Selecione um intem";
            // 
            // btVoltarParaReceitasZe
            // 
            this.btVoltarParaReceitasZe.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarParaReceitasZe.Location = new System.Drawing.Point(1059, 700);
            this.btVoltarParaReceitasZe.Name = "btVoltarParaReceitasZe";
            this.btVoltarParaReceitasZe.Size = new System.Drawing.Size(223, 34);
            this.btVoltarParaReceitasZe.TabIndex = 38;
            this.btVoltarParaReceitasZe.Text = "Voltar para receitas menu";
            this.btVoltarParaReceitasZe.UseVisualStyleBackColor = true;
            this.btVoltarParaReceitasZe.Click += new System.EventHandler(this.btVoltarParaReceitasZe_Click);
            // 
            // Receitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1404, 808);
            this.Controls.Add(this.btVoltarParaReceitasZe);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbOrigemRecebimento);
            this.Controls.Add(this.tbFormaDeREcebimento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateVencimento);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbSituacaoDoRecebimento);
            this.Controls.Add(this.tbQTDTotalDeParcelasPagas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbQTDTotalDeParcelas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbValor);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.btCadastrarCategoria);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.dgvListagemDados);
            this.Controls.Add(this.lbDataDeCadastro);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Name = "Receitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Receitas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dtpDateTime;
        private DataGridView dgvListagemDados;
        private Label lbDataDeCadastro;
        private TextBox tbDescricao;
        private Label lbDescricao;
        private Button btCadastrarCategoria;
        private TextBox tbValor;
        private Label lbValor;
        private TextBox tbQTDTotalDeParcelas;
        private Label label1;
        private TextBox tbQTDTotalDeParcelasPagas;
        private Label label2;
        private Label label3;
        private ComboBox cbSituacaoDoRecebimento;
        private DateTimePicker dateVencimento;
        private Label label4;
        private TextBox tbFormaDeREcebimento;
        private Label label5;
        private Label label6;
        private ComboBox cbOrigemRecebimento;
        private Button btVoltarParaReceitasZe;
    }
}