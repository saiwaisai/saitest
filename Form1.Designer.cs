namespace WindowsFormsApplication1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.BrowseSourceDialog = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.BrowseOutputDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SourceLabel = new System.Windows.Forms.Label();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.InputTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseSourceDialog
            // 
            this.BrowseSourceDialog.FileName = "BrowseSourceDialog";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(70, 29);
            this.button2.TabIndex = 1;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoEllipsis = true;
            this.SourceLabel.Location = new System.Drawing.Point(89, 26);
            this.SourceLabel.MaximumSize = new System.Drawing.Size(150, 20);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(150, 17);
            this.SourceLabel.TabIndex = 2;
            this.SourceLabel.Text = "Source File";
            this.InputTooltip.SetToolTip(this.SourceLabel, "szia");
            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoEllipsis = true;
            this.OutputLabel.Location = new System.Drawing.Point(88, 61);
            this.OutputLabel.MaximumSize = new System.Drawing.Size(150, 20);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(150, 20);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output File";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 88);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 29);
            this.button3.TabIndex = 4;
            this.button3.Text = "Convert";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ProgressLabel
            // 
            this.ProgressLabel.AutoSize = true;
            this.ProgressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ProgressLabel.Location = new System.Drawing.Point(155, 93);
            this.ProgressLabel.Name = "ProgressLabel";
            this.ProgressLabel.Size = new System.Drawing.Size(124, 24);
            this.ProgressLabel.TabIndex = 5;
            this.ProgressLabel.Text = "in progress ...";
            this.ProgressLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 129);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SourceLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "CSV Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog BrowseSourceDialog;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FolderBrowserDialog BrowseOutputDialog;
        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.ToolTip InputTooltip;

    }
}

