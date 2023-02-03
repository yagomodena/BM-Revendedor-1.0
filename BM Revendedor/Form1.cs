using BM_Revendedor.FORMULARIOS.Categoria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BM_Revendedor
{
    public partial class frmPrincipal : Form
    {
        private Form _objForm;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmConCategoria frm = new frmConCategoria();
            frm.Show();
        }

        private void btnCategoria_Click_1(object sender, EventArgs e)
        {
            _objForm?.Close();
            _objForm = new frmConCategoria()
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            pnlExibirFormularios.Controls.Add(_objForm);
            _objForm.Show();
        }
    }
}
