namespace JFiKRegex
{
    partial class JFiKRegex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.regexRichTextBox = new System.Windows.Forms.RichTextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.clear);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 428);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 53);
            this.panel1.TabIndex = 0;
            // 
            // clear
            // 
            this.clear.Dock = System.Windows.Forms.DockStyle.Left;
            this.clear.Location = new System.Drawing.Point(0, 0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 53);
            this.clear.TabIndex = 1;
            this.clear.Text = "Clear";
            this.clear.UseVisualStyleBackColor = true;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.Location = new System.Drawing.Point(549, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 53);
            this.button1.TabIndex = 0;
            this.button1.Text = "GO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.go_Click);
            // 
            // textRichTextBox
            // 
            this.textRichTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.textRichTextBox.Location = new System.Drawing.Point(0, 0);
            this.textRichTextBox.Name = "textRichTextBox";
            this.textRichTextBox.Size = new System.Drawing.Size(624, 184);
            this.textRichTextBox.TabIndex = 1;
            this.textRichTextBox.Text = "";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 88);
            this.panel2.TabIndex = 2;
            // 
            // regexRichTextBox
            // 
            this.regexRichTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.regexRichTextBox.Location = new System.Drawing.Point(0, 272);
            this.regexRichTextBox.Name = "regexRichTextBox";
            this.regexRichTextBox.Size = new System.Drawing.Size(624, 156);
            this.regexRichTextBox.TabIndex = 3;
            this.regexRichTextBox.Text = "";
            // 
            // JFiKRegex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 481);
            this.Controls.Add(this.regexRichTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.textRichTextBox);
            this.Controls.Add(this.panel1);
            this.Name = "JFiKRegex";
            this.Text = "JFiKRegex";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.RichTextBox textRichTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox regexRichTextBox;
    }
}

