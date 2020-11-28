
namespace Rexplorer.Forms {
    partial class ScraperForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.uriText = new System.Windows.Forms.TextBox();
            this.scrape = new System.Windows.Forms.Button();
            this.confingInputFileBrowser = new System.Windows.Forms.Button();
            this.configInputText = new System.Windows.Forms.TextBox();
            this.configText = new System.Windows.Forms.Label();
            this.urlText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uriText
            // 
            this.uriText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.uriText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.uriText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.uriText.Font = new System.Drawing.Font("Verdana", 14F);
            this.uriText.ForeColor = System.Drawing.Color.White;
            this.uriText.Location = new System.Drawing.Point(130, 50);
            this.uriText.Margin = new System.Windows.Forms.Padding(0);
            this.uriText.Name = "uriText";
            this.uriText.Size = new System.Drawing.Size(395, 30);
            this.uriText.TabIndex = 3;
            // 
            // scrape
            // 
            this.scrape.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.scrape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.scrape.FlatAppearance.BorderSize = 0;
            this.scrape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.scrape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scrape.Font = new System.Drawing.Font("Verdana", 28F);
            this.scrape.ForeColor = System.Drawing.Color.White;
            this.scrape.Location = new System.Drawing.Point(9, 261);
            this.scrape.Margin = new System.Windows.Forms.Padding(0);
            this.scrape.Name = "scrape";
            this.scrape.Size = new System.Drawing.Size(516, 60);
            this.scrape.TabIndex = 4;
            this.scrape.Text = "Scrape";
            this.scrape.UseCompatibleTextRendering = true;
            this.scrape.UseVisualStyleBackColor = false;
            this.scrape.Click += new System.EventHandler(this.scrape_Click);
            // 
            // confingInputFileBrowser
            // 
            this.confingInputFileBrowser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.confingInputFileBrowser.FlatAppearance.BorderSize = 0;
            this.confingInputFileBrowser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.confingInputFileBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confingInputFileBrowser.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.confingInputFileBrowser.ForeColor = System.Drawing.Color.White;
            this.confingInputFileBrowser.Location = new System.Drawing.Point(130, 10);
            this.confingInputFileBrowser.Name = "confingInputFileBrowser";
            this.confingInputFileBrowser.Size = new System.Drawing.Size(30, 30);
            this.confingInputFileBrowser.TabIndex = 1;
            this.confingInputFileBrowser.Text = "I";
            this.confingInputFileBrowser.UseCompatibleTextRendering = true;
            this.confingInputFileBrowser.UseVisualStyleBackColor = false;
            this.confingInputFileBrowser.Click += new System.EventHandler(this.confingInputFileBrowser_Click);
            // 
            // configInputText
            // 
            this.configInputText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.configInputText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.configInputText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.configInputText.Font = new System.Drawing.Font("Verdana", 14F);
            this.configInputText.ForeColor = System.Drawing.Color.White;
            this.configInputText.Location = new System.Drawing.Point(170, 10);
            this.configInputText.Margin = new System.Windows.Forms.Padding(0);
            this.configInputText.Name = "configInputText";
            this.configInputText.Size = new System.Drawing.Size(355, 30);
            this.configInputText.TabIndex = 2;
            // 
            // configText
            // 
            this.configText.AutoSize = true;
            this.configText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.configText.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configText.ForeColor = System.Drawing.Color.White;
            this.configText.Location = new System.Drawing.Point(10, 10);
            this.configText.Name = "configText";
            this.configText.Size = new System.Drawing.Size(108, 29);
            this.configText.TabIndex = 9;
            this.configText.Text = "Config: ";
            // 
            // urlText
            // 
            this.urlText.AutoSize = true;
            this.urlText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.urlText.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.urlText.ForeColor = System.Drawing.Color.White;
            this.urlText.Location = new System.Drawing.Point(10, 50);
            this.urlText.Name = "urlText";
            this.urlText.Size = new System.Drawing.Size(66, 29);
            this.urlText.TabIndex = 9;
            this.urlText.Text = "Url: ";
            // 
            // ScraperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(534, 330);
            this.Controls.Add(this.urlText);
            this.Controls.Add(this.configText);
            this.Controls.Add(this.confingInputFileBrowser);
            this.Controls.Add(this.configInputText);
            this.Controls.Add(this.scrape);
            this.Controls.Add(this.uriText);
            this.Name = "ScraperForm";
            this.Text = "ScraperForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox uriText;
        private System.Windows.Forms.Button scrape;
        private System.Windows.Forms.Button confingInputFileBrowser;
        private System.Windows.Forms.TextBox configInputText;
        private System.Windows.Forms.Label configText;
        private System.Windows.Forms.Label urlText;
    }
}