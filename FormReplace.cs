using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEdit
{
    public partial class FormReplace : Form
    {
        public FormReplace()
        {
            InitializeComponent();
        }

        public string sOrigin;
        public string sDest;
        private void btnReplace_Click(object sender, EventArgs e)
        {
            sOrigin = tbOrigin.Text;
            sDest = tbDest.Text;
        }
    }
}
