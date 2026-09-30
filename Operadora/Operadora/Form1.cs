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
            lbl_BemVindo.Enabled = true;
            txt_nome.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumerodeCelular.Enabled = true;
            Txt_NumerodeCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lalbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true;


        }





        private void pcb_image_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Oi_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Orange;
            //Ativar
            lbl_Nome.Enabled = true;
            lbl_BemVindo.Enabled = true;
            txt_nome.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumerodeCelular.Enabled = true;
            Txt_NumerodeCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lalbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true; BackColor = Color.Red; BackColor = Color.DarkOrange;
           
        }

        private void btn_Claro_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Red;
            //Ativar
            lbl_Nome.Enabled = true;
            lbl_BemVindo.Enabled = true;
            txt_nome.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumerodeCelular.Enabled = true;
            Txt_NumerodeCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lalbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true; BackColor = Color.Red;
        }

        private void btn_Tim_CheckedChanged(object sender, EventArgs e)
        {
            //Formatação cores
            BackColor = Color.Blue;
            //Ativar
            lbl_Nome.Enabled = true;
            lbl_BemVindo.Enabled = true;
            txt_nome.Enabled = true;
            txt_OperadoraSelecionada.Enabled = true;
            lbl_OperadoraSelecionada.Enabled = true;
            txt_DDD.Enabled = true;
            lbl_DDD.Enabled = true;
            lbl_NumerodeCelular.Enabled = true;
            Txt_NumerodeCelular.Enabled = true;
            lbl_ValorRecarga.Enabled = true;
            txt_ValorRecarga.Enabled = true;
            lbl_SelecioneValor.Enabled = true;
            btn_RS1.Enabled = true;
            lbl_Validade1.Enabled = true;
            btn_RS2.Enabled = true;
            lalbl_Validade2.Enabled = true;
            btn_RS3.Enabled = true;
            lbl_Validade3.Enabled = true;
            btn_RS4.Enabled = true;
            lbl_Validade4.Enabled = true;
            btn_RS5.Enabled = true;
            lbl_Validade5.Enabled = true;
            btn_RS6.Enabled = true;
            lbl_Validade6.Enabled = true;
            btn_RS7.Enabled = true;
            lbl_Validade7.Enabled = true;
            btn_RS8.Enabled = true;
            lbl_Validade8.Enabled = true; BackColor = Color.Red; BackColor = Color.Blue;
        }

        private void txt_nome_TextChanged(object sender, EventArgs e)
        {
            


        }

        private void txt_OperadoraSelecionada_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void lbl_OperadoraSelecionada_Click(object sender, EventArgs e)
        {

        }
    }
}
