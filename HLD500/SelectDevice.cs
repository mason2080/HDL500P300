using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HLD500
{
    public partial class SelectDevice : Form
    {
        public uint gdevicetype = 0;

        public SelectDevice()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            gdevicetype = 0;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void buttonP3000_Click(object sender, EventArgs e)
        {
            gdevicetype = 1;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
