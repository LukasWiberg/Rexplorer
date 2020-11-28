
namespace Rexplorer {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.SideMenu = new System.Windows.Forms.Panel();
            this.convertButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.scraperButton = new System.Windows.Forms.Button();
            this.SideMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenu
            // 
            this.SideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(0)))), ((int)(((byte)(50)))));
            this.SideMenu.Controls.Add(this.scraperButton);
            this.SideMenu.Controls.Add(this.convertButton);
            this.SideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenu.Location = new System.Drawing.Point(0, 0);
            this.SideMenu.Margin = new System.Windows.Forms.Padding(0);
            this.SideMenu.Name = "SideMenu";
            this.SideMenu.Size = new System.Drawing.Size(214, 690);
            this.SideMenu.TabIndex = 0;
            // 
            // convertButton
            // 
            this.convertButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.convertButton.FlatAppearance.BorderSize = 0;
            this.convertButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.convertButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.convertButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.convertButton.ForeColor = System.Drawing.Color.White;
            this.convertButton.Location = new System.Drawing.Point(10, 10);
            this.convertButton.Margin = new System.Windows.Forms.Padding(0);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(190, 30);
            this.convertButton.TabIndex = 0;
            this.convertButton.Text = "Convert Media";
            this.convertButton.UseCompatibleTextRendering = true;
            this.convertButton.UseVisualStyleBackColor = false;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(214, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 690);
            this.panel1.TabIndex = 1;
            // 
            // scraperButton
            // 
            this.scraperButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(0)))), ((int)(((byte)(40)))));
            this.scraperButton.FlatAppearance.BorderSize = 0;
            this.scraperButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(60)))));
            this.scraperButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.scraperButton.Font = new System.Drawing.Font("Verdana", 14F);
            this.scraperButton.ForeColor = System.Drawing.Color.White;
            this.scraperButton.Location = new System.Drawing.Point(10, 50);
            this.scraperButton.Margin = new System.Windows.Forms.Padding(0);
            this.scraperButton.Name = "scraperButton";
            this.scraperButton.Size = new System.Drawing.Size(190, 30);
            this.scraperButton.TabIndex = 1;
            this.scraperButton.Text = "Scraper";
            this.scraperButton.UseCompatibleTextRendering = true;
            this.scraperButton.UseVisualStyleBackColor = false;
            this.scraperButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SideMenu);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.SideMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel SideMenu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button convertButton;
        private System.Windows.Forms.Button scraperButton;
    }
}

