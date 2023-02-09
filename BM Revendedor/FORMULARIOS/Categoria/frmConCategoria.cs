using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Categoria
{
    public partial class frmConCategoria : Form
    {
        int index;

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
            try
            {
                SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
                SqlCommand cmd = new SqlCommand("INSERT INTO tbCategoria (Nome) VALUES (@Nome)", con);
                cmd.Parameters.AddWithValue("@Nome", txtNomeCategoria.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Clone();
                con = null;
                cmd = null;
                this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
            }
        }
        private void btnExcluirCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
                SqlCommand cmd = new SqlCommand("DELETE tbCategoria WHERE Nome = @Nome", con);
                cmd.Parameters.AddWithValue("@Nome", txtNomeCategoria.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
                cmd.Clone();
                con = null;
                cmd = null;
                this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[index];
            //int id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["ID"].FormattedValue.ToString());
            SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
            SqlCommand cmd = new SqlCommand("Delete tbCategoria WHERE id = '" + index + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Categoria excluída com sucesso!");
            this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
            con.Close();
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
        }
    }
}
