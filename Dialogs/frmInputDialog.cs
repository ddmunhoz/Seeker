using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Seeker
{
    public partial class frmInputDialog : Form
    {
        public frmInputDialog()
        {
            InitializeComponent();
        }

        public string returnInputData { get; set; }
        public string inputDataAsk { get; set; }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (tBoxInputText.Text.Trim() != string.Empty)
            {
                returnInputData = tBoxInputText.Text.Trim();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Attention!", inputDataAsk, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frmInputDialog_Load(object sender, EventArgs e)
        {
            lblInputDescription.Text = inputDataAsk;
        }
    }
}
