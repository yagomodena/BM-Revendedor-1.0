using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM_Revendedor.FORMULARIOS.Clientes
{
    public partial class frmConCliente : Form
    {
        public frmConCliente()
        {
            InitializeComponent();
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            frmCadCliente frm = new frmCadCliente();
            frm.Show();
        }
    }
}
