using Rexplorer.Classes;
using Rexplorer.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rexplorer {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e) {
            new ConvertVideoForm().Show();
        }

        private void button1_Click(object sender, EventArgs e) {
            new ScraperForm().Show();
        }
    }
}
