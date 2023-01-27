namespace BM_Revendedor
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRealizarVenda = new System.Windows.Forms.Button();
            this.btnProduto = new System.Windows.Forms.Button();
            this.btnCategoria = new System.Windows.Forms.Button();
            this.btnMarca = new System.Windows.Forms.Button();
            this.btnFaturamento = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnEntregas = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(693, 38);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "BM Revendedor 1.0";
            // 
            // btnRealizarVenda
            // 
            this.btnRealizarVenda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRealizarVenda.Location = new System.Drawing.Point(12, 49);
            this.btnRealizarVenda.Name = "btnRealizarVenda";
            this.btnRealizarVenda.Size = new System.Drawing.Size(154, 53);
            this.btnRealizarVenda.TabIndex = 6;
            this.btnRealizarVenda.Text = "REALIZAR VENDA";
            this.btnRealizarVenda.UseVisualStyleBackColor = true;
            // 
            // btnProduto
            // 
            this.btnProduto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduto.Location = new System.Drawing.Point(352, 113);
            this.btnProduto.Name = "btnProduto";
            this.btnProduto.Size = new System.Drawing.Size(154, 53);
            this.btnProduto.TabIndex = 7;
            this.btnProduto.Text = "PRODUTO";
            this.btnProduto.UseVisualStyleBackColor = true;
            // 
            // btnCategoria
            // 
            this.btnCategoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategoria.Location = new System.Drawing.Point(182, 113);
            this.btnCategoria.Name = "btnCategoria";
            this.btnCategoria.Size = new System.Drawing.Size(154, 53);
            this.btnCategoria.TabIndex = 8;
            this.btnCategoria.Text = "CATEGORIA";
            this.btnCategoria.UseVisualStyleBackColor = true;
            this.btnCategoria.Click += new System.EventHandler(this.btnCategoria_Click);
            // 
            // btnMarca
            // 
            this.btnMarca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarca.Location = new System.Drawing.Point(12, 113);
            this.btnMarca.Name = "btnMarca";
            this.btnMarca.Size = new System.Drawing.Size(154, 53);
            this.btnMarca.TabIndex = 9;
            this.btnMarca.Text = "MARCA";
            this.btnMarca.UseVisualStyleBackColor = true;
            // 
            // btnFaturamento
            // 
            this.btnFaturamento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFaturamento.Location = new System.Drawing.Point(522, 49);
            this.btnFaturamento.Name = "btnFaturamento";
            this.btnFaturamento.Size = new System.Drawing.Size(154, 53);
            this.btnFaturamento.TabIndex = 10;
            this.btnFaturamento.Text = "FATURAMENTO";
            this.btnFaturamento.UseVisualStyleBackColor = true;
            // 
            // btnEstoque
            // 
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.Location = new System.Drawing.Point(352, 49);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(154, 53);
            this.btnEstoque.TabIndex = 11;
            this.btnEstoque.Text = "ESTOQUE";
            this.btnEstoque.UseVisualStyleBackColor = true;
            // 
            // btnEntregas
            // 
            this.btnEntregas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEntregas.Location = new System.Drawing.Point(182, 49);
            this.btnEntregas.Name = "btnEntregas";
            this.btnEntregas.Size = new System.Drawing.Size(154, 53);
            this.btnEntregas.TabIndex = 12;
            this.btnEntregas.Text = "ENTREGAS";
            this.btnEntregas.UseVisualStyleBackColor = true;
            // 
            // btnClientes
            // 
            this.btnClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClientes.Location = new System.Drawing.Point(522, 113);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(154, 53);
            this.btnClientes.TabIndex = 13;
            this.btnClientes.Text = "CLIENTES";
            this.btnClientes.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(693, 185);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnEntregas);
            this.Controls.Add(this.btnEstoque);
            this.Controls.Add(this.btnFaturamento);
            this.Controls.Add(this.btnMarca);
            this.Controls.Add(this.btnCategoria);
            this.Controls.Add(this.btnProduto);
            this.Controls.Add(this.btnRealizarVenda);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pagina Inicial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRealizarVenda;
        private System.Windows.Forms.Button btnProduto;
        private System.Windows.Forms.Button btnCategoria;
        private System.Windows.Forms.Button btnMarca;
        private System.Windows.Forms.Button btnFaturamento;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnEntregas;
        private System.Windows.Forms.Button btnClientes;
    }
}

