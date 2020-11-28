using System;
using System.Windows.Forms;
using System.Diagnostics;
using Rexplorer.Classes;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace Rexplorer.Forms {
    public partial class ConvertVideoForm : Form {
        public StringBind outputFolderText = new StringBind("");
        public StringBind inputFolderText = new StringBind("");

        public ConvertVideoForm() {
            InitializeComponent();
            inputFolder.DataBindings.Add("Text", inputFolderText, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            outputFolder.DataBindings.Add("Text", outputFolderText, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void inputFolderBrowseButton_Click(object sender, EventArgs e) {
            CommonOpenFileDialog inputFolderDialog = new CommonOpenFileDialog();
            inputFolderDialog.IsFolderPicker = true;
            inputFolderDialog.InitialDirectory = outputFolderText.Value;

            inputFolderDialog.ShowDialog();

            inputFolderText.Value = inputFolderDialog.FileName;
            Focus();
            inputFolderDialog.Dispose();
        }

        private void outputFolderBrowseButton_Click(object sender, EventArgs e) {
            CommonOpenFileDialog outputFolderDialog = new CommonOpenFileDialog();
            outputFolderDialog.IsFolderPicker = true;
            outputFolderDialog.InitialDirectory = outputFolderText.Value;

            outputFolderDialog.ShowDialog();

            outputFolderText.Value = outputFolderDialog.FileName;
            Focus();
            outputFolderDialog.Dispose();
        }

        private void convertMediaButton_Click(object sender, EventArgs e) {
            Task.Run(() => ReMedia.ConvertMediaFolderTask(inputFolderText.Value, outputFolderText.Value));
        }
    }
}
