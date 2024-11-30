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
    public partial class KeyValue : Form
    {
        public KeyValue()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void txt_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_1_KeyDown(object sender, KeyEventArgs e)
        {
            txt_2.AppendText("\r\n" + "Pressionei uma tecla: " + e.KeyCode);
            lbl_Ma.Text = e.KeyCode.ToString().ToUpper();
            lbl_Mi.Text = e.KeyCode.ToString().ToLower();
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_1.Clear();
            txt_2.Clear();
            lbl_Ma.Text = "";
            lbl_Mi.Text = "";
        }
    }
}
