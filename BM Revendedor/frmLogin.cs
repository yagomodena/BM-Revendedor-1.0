using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Abrir a conexão com o banco
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            con.Open();

            string login = "SELECT * FROM usuario WHERE Nome='"+txtUsuario.Text+"'and Senha= '"+txtSenha.Text+"'";
            cmd = new SqlCommand(login, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read()==true) {
                new Form1().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou Senha invalídos!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
        }

        private void chcExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if(chcExibirSenha.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
            }
        }

        private void btnCriarConta_Click(object sender, EventArgs e)
        {
            new frmNovoUsuario().Show();
            this.Hide();
        }
    }
}
