using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JFiKRegex
{
    public partial class JFiKRegex : Form
    {
        public JFiKRegex()
        {
            InitializeComponent();
        }

        private void go_Click(object sender, EventArgs e)
        {
            regexRichTextBox.Text = textRichTextBox.Text.Substring(52,5);
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textRichTextBox.Text = "";
            regexRichTextBox.Text = "";
        }
    }
}
