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
    public partial class Form_ValidaCpf : Form
    {
        public Form_ValidaCpf()
        {
            InitializeComponent();
        }
        private void Msk_Cpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            Lbl_Resultado.Text = Msk_Cpf.Text;
        }

        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Msk_Cpf.Clear();
            Lbl_Resultado.Text = "";
            Msk_Cpf.Focus();
        }

        private void Form_ValidaCpf_Load(object sender, EventArgs e)
        {
            
        }

        private void Btn_Valida_Click(object sender, EventArgs e)
        {

                bool validaCpf = false;
                validaCpf = Cls_Tools.Valida(Msk_Cpf.Text);
                if (validaCpf == true)
                {
                    MessageBox.Show("CPF Válido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cpf Inválido", "Validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }
    }
}
