using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Clientes
{
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtNomeCliente.Text == "")
            {
                MessageBox.Show("Por favor, insira o nome do Cliente!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtNomeCliente.Text != null)
            {
                con.Open();
                string REGISTRO = "INSERT INTO tbClientes VALUES('" + txtNomeCliente.Text + "','" + mskCPF.Text + "','" + mskCelular.Text + "','" + mskResidencial.Text + "','"+"texte"+"','" + mskDataNascimento.Text + "','" + txtRua.Text + "','" + Convert.ToInt32(txtNumero.Text) + "','" + txtBairro.Text + "','"+"teste"+"')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                txtNomeCliente.Text = ""; mskCPF.Text = ""; mskCelular.Text = ""; mskResidencial.Text = ""; mskDataNascimento.Text = ""; txtRua.Text = ""; txtNumero.Text = ""; txtBairro.Text = "";
                MessageBox.Show("Cliente cadastrado com sucesso!", "Menssagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
        }
    }
}
