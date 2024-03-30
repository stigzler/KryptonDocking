using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KryptonDocking.UserControls
{
    public partial class Console : UserControl
    {
        public Console()
        {
            InitializeComponent();
        }

        public void AddText(string text)
        {
            if (richTextBox1.IsDisposed) return;

            richTextBox1.AppendText( text + Environment.NewLine );
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void ClearScreenBT_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void WordWrapBT_Click(object sender, EventArgs e)
        {
            richTextBox1.WordWrap = !richTextBox1.WordWrap;
        }
    }
}
