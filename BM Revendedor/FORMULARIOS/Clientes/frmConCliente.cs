using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Clientes
{
    public partial class frmConCliente : Form
    {
        public frmConCliente()
        {
            InitializeComponent();
        }

        //Abrir a conexão com o banco
        SqlConnection con = new SqlConnection(@"DATA SOURCE=localhost\SQLEXPRESS;Initial CATALOG=BMS;Integrated SECURITY=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente();
            frm.Show();
        }
    }
}
