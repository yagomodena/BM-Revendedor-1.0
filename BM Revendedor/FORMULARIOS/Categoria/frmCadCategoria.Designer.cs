namespace BM_Revendedor.FORMULARIOS.Categoria
{
    partial class frmCadCategoria
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNomeCategoria = new System.Windows.Forms.TextBox();
            this.cmbMarcaCategoria = new System.Windows.Forms.ComboBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome Categoria";
            // 
            // txtNomeCategoria
            // 
            this.txtNomeCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtNomeCategoria.Location = new System.Drawing.Point(16, 32);
            this.txtNomeCategoria.Name = "txtNomeCategoria";
            this.txtNomeCategoria.Size = new System.Drawing.Size(364, 24);
            this.txtNomeCategoria.TabIndex = 1;
            // 
            // cmbMarcaCategoria
            // 
            this.cmbMarcaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.cmbMarcaCategoria.FormattingEnabled = true;
            this.cmbMarcaCategoria.Location = new System.Drawing.Point(16, 87);
            this.cmbMarcaCategoria.Name = "cmbMarcaCategoria";
            this.cmbMarcaCategoria.Size = new System.Drawing.Size(246, 26);
            this.cmbMarcaCategoria.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnCadastrar.Location = new System.Drawing.Point(391, 31);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 27);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Marca que a Categoria faz parte";
            // 
            // frmCadCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 124);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.cmbMarcaCategoria);
            this.Controls.Add(this.txtNomeCategoria);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmCadCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomeCategoria;
        private System.Windows.Forms.ComboBox cmbMarcaCategoria;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
    }
}