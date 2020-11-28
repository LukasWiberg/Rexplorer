
namespace Rexplorer.Forms {
    partial class ConvertVideoForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox inputFolder;

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
        /// 

        private void InitializeComponent() {
            this.inputFolder = new System.Windows.Forms.TextBox();
            this.inputFolderBrowserButton = new System.Windows.Forms.Button();
            this.outputFolderBrowserButton = new System.Windows.Forms.Button();
            this.outputFolder = new System.Windows.Forms.TextBox();
            this.convertMediaButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputFolder
            // 
            this.inputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.inputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputFolder.Font = new System.Drawing.Font("Verdana", 14F);
            this.inputFolder.ForeColor = System.Drawing.Color.White;
            this.inputFolder.Location = new System.Drawing.Point(50, 10);
            this.inputFolder.Margin = new System.Windows.Forms.Padding(0);
            this.inputFolder.Name = "inputFolder";
            this.inputFolder.Size = new System.Drawing.Size(520, 30);
            this.inputFolder.TabIndex = 1;
            // 
            // inputFolderBrowserButton
            // 
            this.inputFolderBrowserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.inputFolderBrowserButton.FlatAppearance.BorderSize = 0;
            this.inputFolderBrowserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.inputFolderBrowserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.inputFolderBrowserButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.inputFolderBrowserButton.ForeColor = System.Drawing.Color.White;
            this.inputFolderBrowserButton.Location = new System.Drawing.Point(10, 10);
            this.inputFolderBrowserButton.Name = "inputFolderBrowserButton";
            this.inputFolderBrowserButton.Size = new System.Drawing.Size(30, 30);
            this.inputFolderBrowserButton.TabIndex = 0;
            this.inputFolderBrowserButton.Text = "I";
            this.inputFolderBrowserButton.UseCompatibleTextRendering = true;
            this.inputFolderBrowserButton.UseVisualStyleBackColor = false;
            this.inputFolderBrowserButton.Click += new System.EventHandler(this.inputFolderBrowseButton_Click);
            // 
            // outputFolderBrowserButton
            // 
            this.outputFolderBrowserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.outputFolderBrowserButton.FlatAppearance.BorderSize = 0;
            this.outputFolderBrowserButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.outputFolderBrowserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outputFolderBrowserButton.Font = new System.Drawing.Font("Verdana", 14F, System.Drawing.FontStyle.Bold);
            this.outputFolderBrowserButton.ForeColor = System.Drawing.Color.White;
            this.outputFolderBrowserButton.Location = new System.Drawing.Point(10, 50);
            this.outputFolderBrowserButton.Name = "outputFolderBrowserButton";
            this.outputFolderBrowserButton.Size = new System.Drawing.Size(30, 30);
            this.outputFolderBrowserButton.TabIndex = 2;
            this.outputFolderBrowserButton.Text = "O";
            this.outputFolderBrowserButton.UseCompatibleTextRendering = true;
            this.outputFolderBrowserButton.UseVisualStyleBackColor = false;
            this.outputFolderBrowserButton.Click += new System.EventHandler(this.outputFolderBrowseButton_Click);
            // 
            // outputFolder
            // 
            this.outputFolder.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.outputFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.outputFolder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputFolder.Font = new System.Drawing.Font("Verdana", 14F);
            this.outputFolder.ForeColor = System.Drawing.Color.White;
            this.outputFolder.Location = new System.Drawing.Point(50, 50);
            this.outputFolder.Margin = new System.Windows.Forms.Padding(0);
            this.outputFolder.Name = "outputFolder";
            this.outputFolder.Size = new System.Drawing.Size(520, 30);
            this.outputFolder.TabIndex = 3;
            // 
            // convertMediaButton
            // 
            this.convertMediaButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.convertMediaButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.convertMediaButton.FlatAppearance.BorderSize = 0;
            this.convertMediaButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.convertMediaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertMediaButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.convertMediaButton.ForeColor = System.Drawing.Color.White;
            this.convertMediaButton.Location = new System.Drawing.Point(10, 320);
            this.convertMediaButton.Margin = new System.Windows.Forms.Padding(0);
            this.convertMediaButton.Name = "convertMediaButton";
            this.convertMediaButton.Size = new System.Drawing.Size(560, 30);
            this.convertMediaButton.TabIndex = 4;
            this.convertMediaButton.Text = "Convert Media";
            this.convertMediaButton.UseCompatibleTextRendering = true;
            this.convertMediaButton.UseVisualStyleBackColor = false;
            this.convertMediaButton.Click += new System.EventHandler(this.convertMediaButton_Click);
            // 
            // ConvertVideoForm
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.convertMediaButton);
            this.Controls.Add(this.outputFolderBrowserButton);
            this.Controls.Add(this.outputFolder);
            this.Controls.Add(this.inputFolderBrowserButton);
            this.Controls.Add(this.inputFolder);
            this.Name = "ConvertVideoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button inputFolderBrowserButton;
        private System.Windows.Forms.Button outputFolderBrowserButton;
        private System.Windows.Forms.TextBox outputFolder;
        private System.Windows.Forms.Button convertMediaButton;
    }
}
