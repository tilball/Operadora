using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operadora
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }

        private void btn_Vivo_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.DarkViolet;
            //Ativar
            lbl_Nome.Enabled = true;
        }

        private void pcb_image_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
