using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form_Mascara : Form
    {
        public Form_Mascara()
        {
            InitializeComponent();
        }

        private void Frm_Mascara_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = true;
            Msk_TxtBox.Mask = "00000000";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }

        private void Btn_Hora_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = false;
            Msk_TxtBox.Mask = "00:00";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }
        private void Btn_Cep_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = false;
            Msk_TxtBox.Mask = "00000-000";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }

        private void Btn_Moeda_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = false;
            Msk_TxtBox.Mask = "$ 000,000,000.000";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }

        private void Btn_Data_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = false;
            Msk_TxtBox.Mask = "00/00/0000";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }

        private void Btn_Telefone_Click(object sender, EventArgs e)
        {
            Msk_TxtBox.UseSystemPasswordChar = false;
            Msk_TxtBox.Mask = "(00)00000-0000";
            Lbl_MascaraAtiva.Text = Msk_TxtBox.Mask;
            Msk_TxtBox.Text = string.Empty;
            Msk_TxtBox.Focus();
        }

        private void Btn_VerConteudo_Click(object sender, EventArgs e)
        {
            Lbl_Conteudo.Text = Msk_TxtBox.Text;
            
        }
    }
}
