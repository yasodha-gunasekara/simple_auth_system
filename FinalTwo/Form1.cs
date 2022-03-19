using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalTwo
{
    public partial class frm_log : Form
    {
        public frm_log()
        {
            InitializeComponent();
        }

        private void btn_log_Click(object sender, EventArgs e)
        {
            if (txt_un.Text=="admin"&&txt_pw.Text=="1234")
            {
                frm_Home hm = new frm_Home();
                hm.ShowDialog();
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txt_pw.UseSystemPasswordChar = true;
            }
            else
            {
                txt_pw.UseSystemPasswordChar = false;
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
