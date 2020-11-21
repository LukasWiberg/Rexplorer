using System;
using System.Windows.Forms;
using System.Diagnostics;
using Rexplorer.Classes;

namespace Rexplorer.Forms {
    public partial class ConvertVideoForm : Form {
        public StringBind outputFolderText = new StringBind("");
        public StringBind inputFolderText = new StringBind("");
        private FolderBrowserDialog inputFolderDialog = new FolderBrowserDialog();
        private FolderBrowserDialog outputFolderDialog = new FolderBrowserDialog();

        public ConvertVideoForm() {
            InitializeComponent();
            inputFolder.DataBindings.Add("Text", inputFolderText, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            outputFolder.DataBindings.Add("Text", outputFolderText, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void inputFolderBrowseButton_Click(object sender, EventArgs e) {
            inputFolderDialog.SelectedPath = outputFolderText.Value;
            inputFolderDialog.ShowDialog();
            inputFolderText.Value = inputFolderDialog.SelectedPath;
        }

        private void outputFolderBrowseButton_Click(object sender, EventArgs e) {
            outputFolderDialog.SelectedPath = outputFolderText.Value;
            outputFolderDialog.ShowDialog();
            outputFolderText.Value = outputFolderDialog.SelectedPath;
        }
    }
}
