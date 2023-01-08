using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_app
{
    public partial class PasswordCTX : Form
    {
        private string pword;
        public bool passCorrect, disableProg;
        public PasswordCTX(string password)
        {
            InitializeComponent();
            pword = password;
            passCorrect = false;
            disableProg = false;
        }

        private void PasswordCTX_Load(object sender, EventArgs e)
        {

        }

        private void pwordtxt_TextChanged(object sender, EventArgs e)
        {
            if(pword == this.pwordtxt.Text && pword.Length == this.pwordtxt.Text.Length)
            {
                passCorrect = true;
                this.Close();
            }
        }

        private void disableApp_CheckedChanged(object sender, EventArgs e)
        {
            if (disableApp.Checked)
            {
                disableProg = true;
            }
            else
                disableProg = false;
        }
    }
}
