using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor
{
    public partial class frmNovoUsuario : Form
    {
        public frmNovoUsuario()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=BMS;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "" && txtSenha.Text == "")
            {
                MessageBox.Show("Usuário ou Senha errado!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Text = "";
                txtSenha.Text = "";
                txtUsuario.Focus();
            }
            else if (txtConfirmarSenha.Text == txtSenha.Text)
            {
                con.Open();
                string REGISTRO = "INSERT INTO Usuario VALUES('" + txtUsuario.Text + "','" + txtSenha.Text + "')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                txtUsuario.Text = ""; txtSenha.Text = ""; txtConfirmarSenha.Text = "";
                MessageBox.Show("Usuário criado com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                new frmLogin().Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Senhas não correspondem!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSenha.Text = "";
                txtConfirmarSenha.Text = "";
                txtSenha.Focus();
            }
        }

        private void chcExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (chcExibirSenha.Checked == true)
            {
                txtSenha.PasswordChar = '\0';
                txtConfirmarSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '*';
                txtConfirmarSenha.PasswordChar = '*';
            }
        }
    }
}
