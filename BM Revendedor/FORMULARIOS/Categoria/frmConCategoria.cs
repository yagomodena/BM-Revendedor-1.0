using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Categoria
{
    public partial class frmConCategoria : Form
    {
        public frmConCategoria()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void frmConCategoria_Load(object sender, EventArgs e)
        {
            //TODO: esta linha de código carrega dados na tabela 'bMSDataSet.tbCategoria'. Você pode movê-la ou removê-la conforme necessário.
            this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNomeCategoria.Text = "";
        }

        private void btnNovoCategoria_Click(object sender, EventArgs e)
        {
            frmCadCategoria frm = new frmCadCategoria();
            frm.Show();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue.ToString());
            //SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
            //con.Open();
            //SqlCommand cmd = new SqlCommand("Delete tbCategoria WHERE id = '" +id+ "'", con);
            //cmd.ExecuteNonQuery();
            //MessageBox.Show("Categoria excluída com sucesso!");
            //this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
            //con.Close();
        }

        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {

            if(dataGridView1.Rows.Count > 0)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
                con.Open();
                //SqlCommand cmd = new SqlCommand("Delete tbCategoria WHERE id = '" + remover + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Categoria excluída com sucesso!");
                this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
                con.Close();
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
        }
    }
}
