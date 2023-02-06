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

namespace BM_Revendedor.FORMULARIOS.Marca
{
    public partial class frmConMarca : Form
    {
        public frmConMarca()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnCadastrarMarca_Click(object sender, EventArgs e)
        {
            if (txtNomeMarca.Text == "")
            {
                MessageBox.Show("Por favor, insira um nome para a Categoria!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNomeMarca.Text = "";
                txtNomeMarca.Focus();
            }
            else if (txtNomeMarca.Text != null)
            {
                con.Open();
                //FALTA CRIAR A TABELA NO SQL
                //NÃO FUNCIONA AINDA...
                string REGISTRO = "INSERT INTO tbCategoria VALUES('" + txtNomeMarca.Text + "')";
                cmd = new SqlCommand(REGISTRO, con);
                cmd.ExecuteReader();
                con.Close();
                txtNomeMarca.Text = "";
                MessageBox.Show("Categoria criada com sucesso!", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
