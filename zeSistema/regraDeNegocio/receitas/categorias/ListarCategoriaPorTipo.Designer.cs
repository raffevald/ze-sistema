namespace zeSistema.regraDeNegocio.receitas.categorias
{
    partial class ListarCategoriaPorTipo
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTipoDeCategoria = new System.Windows.Forms.ComboBox();
            this.btListar = new System.Windows.Forms.Button();
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
            this.dgvListagemDados.Location = new System.Drawing.Point(112, 234);
            this.dgvListagemDados.Name = "dgvListagemDados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDados.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagemDados.RowTemplate.Height = 25;
            this.dgvListagemDados.Size = new System.Drawing.Size(896, 375);
            this.dgvListagemDados.TabIndex = 35;
            // 
            // btCancelar
            // 
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btCancelar.Location = new System.Drawing.Point(706, 186);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(302, 34);
            this.btCancelar.TabIndex = 34;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(112, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "Listar categoria por";
            // 
            // cbTipoDeCategoria
            // 
            this.cbTipoDeCategoria.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbTipoDeCategoria.FormattingEnabled = true;
            this.cbTipoDeCategoria.Items.AddRange(new object[] {
            "Recebimentos",
            "Despesas"});
            this.cbTipoDeCategoria.Location = new System.Drawing.Point(282, 73);
            this.cbTipoDeCategoria.Name = "cbTipoDeCategoria";
            this.cbTipoDeCategoria.Size = new System.Drawing.Size(726, 31);
            this.cbTipoDeCategoria.TabIndex = 32;
            // 
            // btListar
            // 
            this.btListar.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btListar.Location = new System.Drawing.Point(706, 121);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(302, 34);
            this.btListar.TabIndex = 31;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = true;
            this.btListar.Click += new System.EventHandler(this.btListar_Click);
            // 
            // ListarCategoriaPorTipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1121, 665);
            this.Controls.Add(this.dgvListagemDados);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTipoDeCategoria);
            this.Controls.Add(this.btListar);
            this.Name = "ListarCategoriaPorTipo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ListarCategoriaPorTipo";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgvListagemDados;
        private Button btCancelar;
        private Label label1;
        private ComboBox cbTipoDeCategoria;
        private Button btListar;
    }
}