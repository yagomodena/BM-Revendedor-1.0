namespace BM_Revendedor.FORMULARIOS.Clientes
{
    partial class frmConCliente
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtNomeCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.btnExcluirCliente = new System.Windows.Forms.Button();
            this.tbCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSDataSet = new BM_Revendedor.BMSDataSet();
            this.tbCategoriaTableAdapter = new BM_Revendedor.BMSDataSetTableAdapters.tbCategoriaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELCELULAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONERESIDENCIAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATANASCIMENTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMERO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAIRRO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RECEBERPROMOCOESWPP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.txtNomeCliente);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 74);
            this.panel1.TabIndex = 10;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPesquisar.Location = new System.Drawing.Point(496, 15);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(70, 36);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "P";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // txtNomeCliente
            // 
            this.txtNomeCliente.Enabled = false;
            this.txtNomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCliente.Location = new System.Drawing.Point(153, 25);
            this.txtNomeCliente.Name = "txtNomeCliente";
            this.txtNomeCliente.Size = new System.Drawing.Size(329, 26);
            this.txtNomeCliente.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do Cliente";
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnNovoCliente.Location = new System.Drawing.Point(12, 15);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(122, 36);
            this.btnNovoCliente.TabIndex = 7;
            this.btnNovoCliente.Text = "Novo";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCadastrarCliente.Location = new System.Drawing.Point(140, 15);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(122, 36);
            this.btnCadastrarCliente.TabIndex = 6;
            this.btnCadastrarCliente.Text = "Alterar";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCliente
            // 
            this.btnExcluirCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExcluirCliente.Location = new System.Drawing.Point(268, 15);
            this.btnExcluirCliente.Name = "btnExcluirCliente";
            this.btnExcluirCliente.Size = new System.Drawing.Size(122, 36);
            this.btnExcluirCliente.TabIndex = 8;
            this.btnExcluirCliente.Text = "Excluir";
            this.btnExcluirCliente.UseVisualStyleBackColor = true;
            // 
            // tbCategoriaBindingSource
            // 
            this.tbCategoriaBindingSource.DataMember = "tbCategoria";
            this.tbCategoriaBindingSource.DataSource = this.bMSDataSet;
            // 
            // bMSDataSet
            // 
            this.bMSDataSet.DataSetName = "BMSDataSet";
            this.bMSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbCategoriaTableAdapter
            // 
            this.tbCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnNovoCliente);
            this.panel2.Controls.Add(this.btnCadastrarCliente);
            this.panel2.Controls.Add(this.btnExcluirCliente);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 387);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 63);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME,
            this.CPF,
            this.TELCELULAR,
            this.TELEFONERESIDENCIAL,
            this.SEXO,
            this.DATANASCIMENTO,
            this.RUA,
            this.NUMERO,
            this.BAIRRO,
            this.RECEBERPROMOCOESWPP});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(886, 313);
            this.dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 50;
            // 
            // NOME
            // 
            this.NOME.HeaderText = "NOME";
            this.NOME.MinimumWidth = 6;
            this.NOME.Name = "NOME";
            this.NOME.ReadOnly = true;
            this.NOME.Width = 150;
            // 
            // CPF
            // 
            this.CPF.HeaderText = "CPF";
            this.CPF.MinimumWidth = 6;
            this.CPF.Name = "CPF";
            this.CPF.ReadOnly = true;
            this.CPF.Width = 125;
            // 
            // TELCELULAR
            // 
            this.TELCELULAR.HeaderText = "TELEFONE CELULAR";
            this.TELCELULAR.MinimumWidth = 6;
            this.TELCELULAR.Name = "TELCELULAR";
            this.TELCELULAR.ReadOnly = true;
            this.TELCELULAR.Width = 125;
            // 
            // TELEFONERESIDENCIAL
            // 
            this.TELEFONERESIDENCIAL.HeaderText = "TEL. RESIDENCIAL";
            this.TELEFONERESIDENCIAL.MinimumWidth = 6;
            this.TELEFONERESIDENCIAL.Name = "TELEFONERESIDENCIAL";
            this.TELEFONERESIDENCIAL.ReadOnly = true;
            this.TELEFONERESIDENCIAL.Width = 125;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.MinimumWidth = 6;
            this.SEXO.Name = "SEXO";
            this.SEXO.ReadOnly = true;
            this.SEXO.Width = 80;
            // 
            // DATANASCIMENTO
            // 
            this.DATANASCIMENTO.HeaderText = "DATA NASC.";
            this.DATANASCIMENTO.MinimumWidth = 6;
            this.DATANASCIMENTO.Name = "DATANASCIMENTO";
            this.DATANASCIMENTO.ReadOnly = true;
            this.DATANASCIMENTO.Width = 80;
            // 
            // RUA
            // 
            this.RUA.HeaderText = "RUA";
            this.RUA.MinimumWidth = 6;
            this.RUA.Name = "RUA";
            this.RUA.ReadOnly = true;
            this.RUA.Width = 125;
            // 
            // NUMERO
            // 
            this.NUMERO.HeaderText = "NUMERO";
            this.NUMERO.MinimumWidth = 6;
            this.NUMERO.Name = "NUMERO";
            this.NUMERO.ReadOnly = true;
            this.NUMERO.Width = 50;
            // 
            // BAIRRO
            // 
            this.BAIRRO.HeaderText = "BAIRRO";
            this.BAIRRO.MinimumWidth = 6;
            this.BAIRRO.Name = "BAIRRO";
            this.BAIRRO.ReadOnly = true;
            this.BAIRRO.Width = 125;
            // 
            // RECEBERPROMOCOESWPP
            // 
            this.RECEBERPROMOCOESWPP.HeaderText = "PROMOCOES WPP";
            this.RECEBERPROMOCOESWPP.MinimumWidth = 6;
            this.RECEBERPROMOCOESWPP.Name = "RECEBERPROMOCOESWPP";
            this.RECEBERPROMOCOESWPP.ReadOnly = true;
            this.RECEBERPROMOCOESWPP.Width = 25;
            // 
            // frmConCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConCliente";
            this.Text = "Consulta de Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.TextBox txtNomeCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Button btnExcluirCliente;
        private System.Windows.Forms.BindingSource tbCategoriaBindingSource;
        private BMSDataSet bMSDataSet;
        private BMSDataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
        private System.Windows.Forms.DataGridViewTextBoxColumn CPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELCELULAR;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONERESIDENCIAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATANASCIMENTO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMERO;
        private System.Windows.Forms.DataGridViewTextBoxColumn BAIRRO;
        private System.Windows.Forms.DataGridViewTextBoxColumn RECEBERPROMOCOESWPP;
    }
}