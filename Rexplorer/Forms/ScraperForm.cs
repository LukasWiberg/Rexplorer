using Rexplorer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Rexplorer.Forms {
    public partial class ScraperForm : Form {
        private string linkExportString;

        public StringBind scrapeURI = new StringBind("");
        public StringBind configPath = new StringBind("");

        public ScraperForm() {
            InitializeComponent();
            uriText.DataBindings.Add("Text", scrapeURI, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
            configInputText.DataBindings.Add("Text", configPath, "Value", true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void scrape_Click(object sender, EventArgs e) {
            ReScrape scraper = new ReScrape();
            string[] urls = scraper.Scrape(scrapeURI.Value, configPath.Value);
            Debug.WriteLine("Total number of links: " + urls.Count());
            linkExportString = String.Join("\n", urls);
            exportToClipboardButton.Enabled = true;
        }


        private void confingInputFileBrowser_Click(object sender, EventArgs e) {

            OpenFileDialog configFileDialog = new OpenFileDialog();
            configFileDialog.InitialDirectory = configPath.Value;
            configFileDialog.Filter = "json files (*.json)|*.json";
            configFileDialog.FilterIndex = 0;

            configFileDialog.ShowDialog();

            configPath.Value = configFileDialog.FileName;
            Focus();
            configFileDialog.Dispose();
        }

        private void exportToClipboardButton_Click(object sender, EventArgs e) {
            Clipboard.SetText(linkExportString);
            exportToClipboardButton.Enabled = false;
        }
    }
}
