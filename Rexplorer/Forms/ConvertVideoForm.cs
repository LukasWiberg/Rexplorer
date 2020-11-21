using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using Rexplorer.Classes;

namespace Rexplorer.Forms {
    public partial class ConvertVideoForm : Form {
        private FolderBrowserDialog dialog;

        private void textBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void startConversion_Click(object sender, EventArgs e) {

        }

        private void inputFolderBrowserButton_Click(object sender, EventArgs e) {
            dialog.ShowDialog();
            Debug.WriteLine(dialog.SelectedPath);
        }

        private void outputFolderBrowserButton1_Click(object sender, EventArgs e) {
            dialog.ShowDialog();
            Debug.WriteLine(dialog.SelectedPath);
        }

        private void InitializeComponent() {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(31, 27);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // ConvertVideoForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textBox1);
            this.Name = "ConvertVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
