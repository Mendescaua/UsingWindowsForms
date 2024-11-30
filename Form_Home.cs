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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }

        //Btn_Detk
        private void button1_Click(object sender, EventArgs e)
        {

        }
        
        private void Btn_KeyValue_Click(object sender, EventArgs e)
        {
            //Codigo que direciona para outro form
            KeyValue Form_KeyValue = new KeyValue();
            Form_KeyValue.ShowDialog();
        }

        private void Btn_Mascara_Click(object sender, EventArgs e)
        {
            Form_Mascara f = new Form_Mascara();
            f.ShowDialog();
            
        }

        private void Btn_ValidaCpf_Click(object sender, EventArgs e)
        {
            Form_ValidaCpf f = new Form_ValidaCpf();
            f.ShowDialog();
        }

        private void Btn_ValidaSenha_Click(object sender, EventArgs e)
        {
            ValidaSenha Form_ValidaSenha = new ValidaSenha();
            Form_ValidaSenha.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form_ChangeLabel f = new Form_ChangeLabel();
            f.ShowDialog();
        }
    }
}
