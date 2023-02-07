namespace BM_Revendedor.FORMULARIOS.Categoria
{
    partial class frmConCategoria
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluirCategoria = new System.Windows.Forms.Button();
            this.btnNovoCategoria = new System.Windows.Forms.Button();
            this.btnCadastrarCategoria = new System.Windows.Forms.Button();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSDataSet = new BM_Revendedor.BMSDataSet();
            this.tbCategoriaTableAdapter = new BM_Revendedor.BMSDataSetTableAdapters.tbCategoriaTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnExcluirCategoria);
            this.panel1.Controls.Add(this.btnNovoCategoria);
            this.panel1.Controls.Add(this.btnCadastrarCategoria);
            this.panel1.Controls.Add(this.txtNomeCategoria);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(578, 121);
            this.panel1.TabIndex = 0;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnPesquisar.Location = new System.Drawing.Point(532, 24);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(34, 36);
            this.btnPesquisar.TabIndex = 10;
            this.btnPesquisar.Text = "P";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCancelar.Location = new System.Drawing.Point(421, 69);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(122, 36);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluirCategoria
            // 
            this.btnExcluirCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExcluirCategoria.Location = new System.Drawing.Point(288, 69);
            this.btnExcluirCategoria.Name = "btnExcluirCategoria";
            this.btnExcluirCategoria.Size = new System.Drawing.Size(122, 36);
            this.btnExcluirCategoria.TabIndex = 8;
            this.btnExcluirCategoria.Text = "Excluir";
            this.btnExcluirCategoria.UseVisualStyleBackColor = true;
            this.btnExcluirCategoria.Click += new System.EventHandler(this.btnExcluirCategoria_Click);
            // 
            // btnNovoCategoria
            // 
            this.btnNovoCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnNovoCategoria.Location = new System.Drawing.Point(32, 69);
            this.btnNovoCategoria.Name = "btnNovoCategoria";
            this.btnNovoCategoria.Size = new System.Drawing.Size(122, 36);
            this.btnNovoCategoria.TabIndex = 7;
            this.btnNovoCategoria.Text = "Novo";
            this.btnNovoCategoria.UseVisualStyleBackColor = true;
            this.btnNovoCategoria.Click += new System.EventHandler(this.btnNovoCategoria_Click);
            // 
            // btnCadastrarCategoria
            // 
            this.btnCadastrarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnCadastrarCategoria.Location = new System.Drawing.Point(160, 69);
            this.btnCadastrarCategoria.Name = "btnCadastrarCategoria";
            this.btnCadastrarCategoria.Size = new System.Drawing.Size(122, 36);
            this.btnCadastrarCategoria.TabIndex = 6;
            this.btnCadastrarCategoria.Text = "Cadastrar";
            this.btnCadastrarCategoria.UseVisualStyleBackColor = true;
            this.btnCadastrarCategoria.Click += new System.EventHandler(this.btnCadastrarCategoria_Click);
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Enabled = false;
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeCategoria.Location = new System.Drawing.Point(189, 34);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(329, 26);
            this.txtNomeCategoria.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(48, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Categoria";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tbCategoriaBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 121);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(578, 344);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
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
            // frmConCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(578, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta Categorias";
            this.Load += new System.EventHandler(this.frmConCategoria_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bMSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCadastrarCategoria;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluirCategoria;
        private System.Windows.Forms.Button btnNovoCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private BMSDataSet bMSDataSet;
        private System.Windows.Forms.BindingSource tbCategoriaBindingSource;
        private BMSDataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnPesquisar;
    }
}