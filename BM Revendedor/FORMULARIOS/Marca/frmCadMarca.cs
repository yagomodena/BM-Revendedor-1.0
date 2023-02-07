using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Marca
{
    public partial class frmCadMarca : Form
    {
        public frmCadMarca()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeMarca.Text == "")
            {
                MessageBox.Show("Por favor, insira um nome para a Marca!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeMarca.Text = "";
                txtNomeMarca.Focus();
            }
            else if (txtNomeMarca.Text != null)
            {
                //con.Open();
                //string REGISTRO = "INSERT INTO tbMarca VALUES('" + txtNomeMarca.Text + "')";
                //cmd = new SqlCommand(REGISTRO, con);
                //cmd.ExecuteReader();
                //con.Close();
                //txtNomeMarca.Text = "";
                //MessageBox.Show("Marca criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //this.Close();

                con.Open();
                string REGISTRO = "INSERT INTO tbMarca VALUES('" + txtNomeMarca.Text + "')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                txtNomeMarca.Text = "";
                MessageBox.Show("Usuário criado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmLogin().Show();
                this.Hide();
            }
        }
    }
}
