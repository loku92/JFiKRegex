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
            DFA dfs = new DFA(textRichTextBox.Text);
            regexRichTextBox.Text = dfs.analyse();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textRichTextBox.Text = "";
            regexRichTextBox.Text = "";
        }
    }
}
