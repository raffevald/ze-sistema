namespace zeSistema.regraDeNegocio.receitas
{
    partial class CategoriaDasReceitas
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
            this.btCadastrarCategoria = new System.Windows.Forms.Button();
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.lbDescricao = new System.Windows.Forms.Label();
            this.lbDataDeCadastro = new System.Windows.Forms.Label();
            this.dgvListagemDados = new System.Windows.Forms.DataGridView();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btTrocarDeUsuario = new System.Windows.Forms.Button();
            this.btVoltarTelaPrincipal = new System.Windows.Forms.Button();
            this.btListarCategoriasReceitas = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbDeletarCategoria = new System.Windows.Forms.Button();
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.lbCodigo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).BeginInit();
            this.SuspendLayout();
            // 
            // btCadastrarCategoria
            // 
            this.btCadastrarCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCadastrarCategoria.Location = new System.Drawing.Point(857, 126);
            this.btCadastrarCategoria.Name = "btCadastrarCategoria";
            this.btCadastrarCategoria.Size = new System.Drawing.Size(223, 34);
            this.btCadastrarCategoria.TabIndex = 13;
            this.btCadastrarCategoria.Text = "Cadastrar categoria";
            this.btCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btCadastrarCategoria.Click += new System.EventHandler(this.btCadastrarCategoria_Click);
            // 
            // tbDescricao
            // 
            this.tbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDescricao.Location = new System.Drawing.Point(279, 78);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(291, 31);
            this.tbDescricao.TabIndex = 12;
            // 
            // lbDescricao
            // 
            this.lbDescricao.AutoSize = true;
            this.lbDescricao.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDescricao.Location = new System.Drawing.Point(185, 81);
            this.lbDescricao.Name = "lbDescricao";
            this.lbDescricao.Size = new System.Drawing.Size(88, 25);
            this.lbDescricao.TabIndex = 11;
            this.lbDescricao.Text = "Descrição";
            // 
            // lbDataDeCadastro
            // 
            this.lbDataDeCadastro.AutoSize = true;
            this.lbDataDeCadastro.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDataDeCadastro.Location = new System.Drawing.Point(585, 81);
            this.lbDataDeCadastro.Name = "lbDataDeCadastro";
            this.lbDataDeCadastro.Size = new System.Drawing.Size(147, 25);
            this.lbDataDeCadastro.TabIndex = 14;
            this.lbDataDeCadastro.Text = "Data de cadastro";
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
            this.dgvListagemDados.Location = new System.Drawing.Point(185, 253);
            this.dgvListagemDados.Name = "dgvListagemDados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagemDados.RowTemplate.Height = 25;
            this.dgvListagemDados.Size = new System.Drawing.Size(895, 349);
            this.dgvListagemDados.TabIndex = 16;
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.CustomFormat = "";
            this.dtpDateTime.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateTime.Location = new System.Drawing.Point(738, 78);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(342, 31);
            this.dtpDateTime.TabIndex = 17;
            // 
            // btTrocarDeUsuario
            // 
            this.btTrocarDeUsuario.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btTrocarDeUsuario.Location = new System.Drawing.Point(1075, 624);
            this.btTrocarDeUsuario.Name = "btTrocarDeUsuario";
            this.btTrocarDeUsuario.Size = new System.Drawing.Size(162, 34);
            this.btTrocarDeUsuario.TabIndex = 19;
            this.btTrocarDeUsuario.Text = "Trocar de usuario";
            this.btTrocarDeUsuario.UseVisualStyleBackColor = true;
            this.btTrocarDeUsuario.Click += new System.EventHandler(this.btTrocarDeUsuario_Click);
            // 
            // btVoltarTelaPrincipal
            // 
            this.btVoltarTelaPrincipal.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btVoltarTelaPrincipal.Location = new System.Drawing.Point(855, 624);
            this.btVoltarTelaPrincipal.Name = "btVoltarTelaPrincipal";
            this.btVoltarTelaPrincipal.Size = new System.Drawing.Size(186, 34);
            this.btVoltarTelaPrincipal.TabIndex = 18;
            this.btVoltarTelaPrincipal.Text = "Voltar a tela principal";
            this.btVoltarTelaPrincipal.UseVisualStyleBackColor = true;
            this.btVoltarTelaPrincipal.Click += new System.EventHandler(this.btVoltarTelaPrincipal_Click);
            // 
            // btListarCategoriasReceitas
            // 
            this.btListarCategoriasReceitas.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btListarCategoriasReceitas.Location = new System.Drawing.Point(185, 198);
            this.btListarCategoriasReceitas.Name = "btListarCategoriasReceitas";
            this.btListarCategoriasReceitas.Size = new System.Drawing.Size(223, 34);
            this.btListarCategoriasReceitas.TabIndex = 20;
            this.btListarCategoriasReceitas.Text = "Listar categoria";
            this.btListarCategoriasReceitas.UseVisualStyleBackColor = true;
            this.btListarCategoriasReceitas.Click += new System.EventHandler(this.btListarCategoriasReceitas_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(518, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Atualizar categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbDeletarCategoria
            // 
            this.tbDeletarCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbDeletarCategoria.Location = new System.Drawing.Point(855, 198);
            this.tbDeletarCategoria.Name = "tbDeletarCategoria";
            this.tbDeletarCategoria.Size = new System.Drawing.Size(223, 34);
            this.tbDeletarCategoria.TabIndex = 22;
            this.tbDeletarCategoria.Text = "Excluir categoria";
            this.tbDeletarCategoria.UseVisualStyleBackColor = true;
            this.tbDeletarCategoria.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbCodigo.Location = new System.Drawing.Point(279, 129);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(291, 31);
            this.tbCodigo.TabIndex = 24;
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCodigo.Location = new System.Drawing.Point(185, 132);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(71, 25);
            this.lbCodigo.TabIndex = 23;
            this.lbCodigo.Text = "Codigo";
            // 
            // CategoriaDasReceitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.lbCodigo);
            this.Controls.Add(this.tbDeletarCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btListarCategoriasReceitas);
            this.Controls.Add(this.btTrocarDeUsuario);
            this.Controls.Add(this.btVoltarTelaPrincipal);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.dgvListagemDados);
            this.Controls.Add(this.lbDataDeCadastro);
            this.Controls.Add(this.btCadastrarCategoria);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.lbDescricao);
            this.Name = "CategoriaDasReceitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CategoriaDasReceitas";
            this.Load += new System.EventHandler(this.CategoriaDasReceitas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btCadastrarCategoria;
        private TextBox tbDescricao;
        private Label lbDescricao;
        private Label lbDataDeCadastro;
        private DataGridView dgvListagemDados;
        private DateTimePicker dtpDateTime;
        private Button btTrocarDeUsuario;
        private Button btVoltarTelaPrincipal;
        private Button btListarCategoriasReceitas;
        private Button button1;
        private Button tbDeletarCategoria;
        private TextBox tbCodigo;
        private Label lbCodigo;
    }
}