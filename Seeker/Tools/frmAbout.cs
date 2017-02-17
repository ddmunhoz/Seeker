using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Seeker
{
    public partial class frmAbout : Form
    {        
        public frmAbout()
        {
            InitializeComponent();
        }

  
        

        private void llPWebsite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(llPWebsite.Text);
        }

       
    }
}
