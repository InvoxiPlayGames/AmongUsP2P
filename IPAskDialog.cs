using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmongUsP2P
{
    public partial class IPAskDialog : Form
    {
        public string ipAddr;

        public IPAskDialog()
        {
            InitializeComponent();
        }

        private void joinButton_Click(object sender, EventArgs e)
        {
            ipAddr = ipBox.Text;
            pleaseBringToFront.Stop();
            Close();
        }

        private void IPAskDialog_Load(object sender, EventArgs e)
        {
            pleaseBringToFront.Start();
        }

        private void pleaseBringToFront_Tick(object sender, EventArgs e)
        {
            BringToFront();
        }
    }
}
