using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mandadero2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDesc.Focus();
            KeyPreview = true;
        }

        private void btnSn1d_Click(object sender, EventArgs e)
        {
            Close();
        }

        public String getText()
        {
            return txtDesc.Text;
        }

        private void btnOKplus_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Control.ModifierKeys & Keys.Control) == Keys.Control && e.KeyChar == '\n')
            { //OK+
                DialogResult = DialogResult.Yes;
                Close();
            }
        }
    }
}
