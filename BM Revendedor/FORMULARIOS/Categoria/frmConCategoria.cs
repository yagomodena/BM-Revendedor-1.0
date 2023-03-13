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

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.tbCategoriaTableAdapter.Fill(this.bMSDataSet.tbCategoria);
        }
    }
}
