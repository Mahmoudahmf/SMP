using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMP
{
    public partial class Toast : Form
    {
        public Toast()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labl_caption_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
