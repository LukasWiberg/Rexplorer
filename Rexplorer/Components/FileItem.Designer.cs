
namespace Rexplorer.Components {
    partial class FileItem {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fileNameText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // fileNameText
            // 
            this.fileNameText.Font = new System.Drawing.Font("Verdana", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileNameText.Location = new System.Drawing.Point(0, 0);
            this.fileNameText.Margin = new System.Windows.Forms.Padding(0);
            this.fileNameText.Name = "fileNameText";
            this.fileNameText.Size = new System.Drawing.Size(360, 30);
            this.fileNameText.TabIndex = 0;
            this.fileNameText.Text = "fileName";
            // 
            // FileItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.fileNameText);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MaximumSize = new System.Drawing.Size(4160, 30);
            this.MinimumSize = new System.Drawing.Size(240, 30);
            this.Name = "FileItem";
            this.Size = new System.Drawing.Size(640, 30);
            this.Load += new System.EventHandler(this.FileItem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label fileNameText;
    }
}
