namespace BrowsersBenchmark
{
    partial class Form1
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
            this.ChromeButton = new System.Windows.Forms.Button();
            this.PageURL = new System.Windows.Forms.TextBox();
            this.EdgeButton = new System.Windows.Forms.Button();
            this.ExplorerButton = new System.Windows.Forms.Button();
            this.FirefoxButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LoadingPageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ChromeButton
            // 
            this.ChromeButton.Location = new System.Drawing.Point(399, 85);
            this.ChromeButton.Name = "ChromeButton";
            this.ChromeButton.Size = new System.Drawing.Size(96, 32);
            this.ChromeButton.TabIndex = 0;
            this.ChromeButton.Text = "Chrome";
            this.ChromeButton.UseVisualStyleBackColor = true;
            this.ChromeButton.Click += new System.EventHandler(this.ChromeButton_Click);
            // 
            // PageURL
            // 
            this.PageURL.Location = new System.Drawing.Point(151, 35);
            this.PageURL.Name = "PageURL";
            this.PageURL.Size = new System.Drawing.Size(218, 20);
            this.PageURL.TabIndex = 1;
            this.PageURL.Text = "https://";
            this.PageURL.TextChanged += new System.EventHandler(this.PageURL_TextChanged);
            // 
            // EdgeButton
            // 
            this.EdgeButton.Location = new System.Drawing.Point(151, 85);
            this.EdgeButton.Name = "EdgeButton";
            this.EdgeButton.Size = new System.Drawing.Size(96, 32);
            this.EdgeButton.TabIndex = 2;
            this.EdgeButton.Text = "Edge";
            this.EdgeButton.UseVisualStyleBackColor = true;
            this.EdgeButton.Click += new System.EventHandler(this.EdgeButton_Click);
            // 
            // ExplorerButton
            // 
            this.ExplorerButton.Location = new System.Drawing.Point(273, 85);
            this.ExplorerButton.Name = "ExplorerButton";
            this.ExplorerButton.Size = new System.Drawing.Size(96, 32);
            this.ExplorerButton.TabIndex = 3;
            this.ExplorerButton.Text = "Explorer";
            this.ExplorerButton.UseVisualStyleBackColor = true;
            this.ExplorerButton.Click += new System.EventHandler(this.ExplorerButton_Click);
            // 
            // FirefoxButton
            // 
            this.FirefoxButton.Location = new System.Drawing.Point(22, 85);
            this.FirefoxButton.Name = "FirefoxButton";
            this.FirefoxButton.Size = new System.Drawing.Size(96, 32);
            this.FirefoxButton.TabIndex = 4;
            this.FirefoxButton.Text = "Firefox";
            this.FirefoxButton.UseVisualStyleBackColor = true;
            this.FirefoxButton.Click += new System.EventHandler(this.FirefoxButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(231, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Page URL";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loading page time";
            // 
            // LoadingPageLabel
            // 
            this.LoadingPageLabel.AutoSize = true;
            this.LoadingPageLabel.Location = new System.Drawing.Point(239, 209);
            this.LoadingPageLabel.Name = "LoadingPageLabel";
            this.LoadingPageLabel.Size = new System.Drawing.Size(49, 13);
            this.LoadingPageLabel.TabIndex = 7;
            this.LoadingPageLabel.Text = "00:00:00";
          
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 371);
            this.Controls.Add(this.LoadingPageLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FirefoxButton);
            this.Controls.Add(this.ExplorerButton);
            this.Controls.Add(this.EdgeButton);
            this.Controls.Add(this.PageURL);
            this.Controls.Add(this.ChromeButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChromeButton;
        private System.Windows.Forms.TextBox PageURL;
        private System.Windows.Forms.Button EdgeButton;
        private System.Windows.Forms.Button ExplorerButton;
        private System.Windows.Forms.Button FirefoxButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LoadingPageLabel;
    }
}

