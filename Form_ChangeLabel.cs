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
    public partial class Form_ChangeLabel : Form
    {
        public Form_ChangeLabel()
        {
            InitializeComponent();
        }

        private void Btn_MudarLabel_Click(object sender, EventArgs e)
        {
            if (Txt_Write.Text == string.Empty)
            {
                Lbl_Show.Text = ".....";
            }
            else
            {
                Lbl_Show.Text = Txt_Write.Text;
            }
        }

        private void Txt_Write_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
