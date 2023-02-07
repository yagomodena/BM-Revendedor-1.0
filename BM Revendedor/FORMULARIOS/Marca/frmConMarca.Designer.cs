namespace BM_Revendedor.FORMULARIOS.Marca
{
    partial class frmConMarca
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
            this.txtNomeMarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNovaMarca = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluirMarca = new System.Windows.Forms.Button();
            this.tbCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bMSDataSet = new BM_Revendedor.BMSDataSet();
            this.tbCategoriaTableAdapter = new BM_Revendedor.BMSDataSetTableAdapters.tbCategoriaTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOME = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.panel1.Controls.Add(this.txtNomeMarca);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 74);
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
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtNomeMarca
            // 
            this.txtNomeMarca.Enabled = false;
            this.txtNomeMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNomeMarca.Location = new System.Drawing.Point(123, 25);
            this.txtNomeMarca.Name = "txtNomeMarca";
            this.txtNomeMarca.Size = new System.Drawing.Size(359, 26);
            this.txtNomeMarca.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome Marca";
            // 
            // btnNovaMarca
            // 
            this.btnNovaMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnNovaMarca.Location = new System.Drawing.Point(12, 15);
            this.btnNovaMarca.Name = "btnNovaMarca";
            this.btnNovaMarca.Size = new System.Drawing.Size(122, 36);
            this.btnNovaMarca.TabIndex = 7;
            this.btnNovaMarca.Text = "Novo";
            this.btnNovaMarca.UseVisualStyleBackColor = true;
            this.btnNovaMarca.Click += new System.EventHandler(this.btnNovaMarca_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnAlterar.Location = new System.Drawing.Point(140, 15);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(122, 36);
            this.btnAlterar.TabIndex = 6;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            // 
            // btnExcluirMarca
            // 
            this.btnExcluirMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btnExcluirMarca.Location = new System.Drawing.Point(268, 15);
            this.btnExcluirMarca.Name = "btnExcluirMarca";
            this.btnExcluirMarca.Size = new System.Drawing.Size(122, 36);
            this.btnExcluirMarca.TabIndex = 8;
            this.btnExcluirMarca.Text = "Excluir";
            this.btnExcluirMarca.UseVisualStyleBackColor = true;
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
            this.panel2.Controls.Add(this.btnNovaMarca);
            this.panel2.Controls.Add(this.btnAlterar);
            this.panel2.Controls.Add(this.btnExcluirMarca);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 402);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(594, 63);
            this.panel2.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NOME});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(594, 328);
            this.dataGridView1.TabIndex = 13;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // NOME
            // 
            this.NOME.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NOME.HeaderText = "Nome";
            this.NOME.MinimumWidth = 6;
            this.NOME.Name = "NOME";
            // 
            // frmConMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(594, 465);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmConMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Marca";
            this.Load += new System.EventHandler(this.frmConMarca_Load);
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
        private System.Windows.Forms.TextBox txtNomeMarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNovaMarca;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluirMarca;
        private System.Windows.Forms.BindingSource tbCategoriaBindingSource;
        private BMSDataSet bMSDataSet;
        private BMSDataSetTableAdapters.tbCategoriaTableAdapter tbCategoriaTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOME;
    }
}