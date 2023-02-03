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
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnCadastrarCategoria_Click(object sender, EventArgs e)
        {
            if (txtNomeCategoria.Text == "")
            {
                MessageBox.Show("Por favor, insira um nome para a Categoria!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeCategoria.Text = "";
                txtNomeCategoria.Focus();
            }
            else if (txtNomeCategoria.Text != null)
            {
                con.Open();
                string REGISTRO = "INSERT INTO tbCategoria VALUES('" + txtNomeCategoria.Text + "')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                txtNomeCategoria.Text = "";
                MessageBox.Show("Categoria criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
