namespace WindowsFormsApplication1
{
    partial class ClipboardSnoop_Main
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
            this.tabPanel = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.clipboardText = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.clipboardImage = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.clipboardData = new System.Windows.Forms.Label();
            this.htmlTab = new System.Windows.Forms.TabPage();
            this.rtfHTML = new System.Windows.Forms.RichTextBox();
            this.browseHTML = new System.Windows.Forms.WebBrowser();
            this.fmTextboxTab = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.fmTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.fmBrowser = new System.Windows.Forms.WebBrowser();
            this.tabPanel.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clipboardImage)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.htmlTab.SuspendLayout();
            this.fmTextboxTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPanel
            // 
            this.tabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPanel.Controls.Add(this.tabPage1);
            this.tabPanel.Controls.Add(this.tabPage2);
            this.tabPanel.Controls.Add(this.tabPage3);
            this.tabPanel.Controls.Add(this.htmlTab);
            this.tabPanel.Controls.Add(this.fmTextboxTab);
            this.tabPanel.Location = new System.Drawing.Point(0, 31);
            this.tabPanel.Name = "tabPanel";
            this.tabPanel.SelectedIndex = 0;
            this.tabPanel.Size = new System.Drawing.Size(918, 490);
            this.tabPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.clipboardText);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(910, 464);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Text";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(3, 225);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(904, 236);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // clipboardText
            // 
            this.clipboardText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clipboardText.Location = new System.Drawing.Point(3, 3);
            this.clipboardText.Name = "clipboardText";
            this.clipboardText.Size = new System.Drawing.Size(904, 216);
            this.clipboardText.TabIndex = 0;
            this.clipboardText.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.clipboardImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(910, 464);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Image";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // clipboardImage
            // 
            this.clipboardImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipboardImage.Location = new System.Drawing.Point(3, 3);
            this.clipboardImage.Name = "clipboardImage";
            this.clipboardImage.Size = new System.Drawing.Size(904, 458);
            this.clipboardImage.TabIndex = 0;
            this.clipboardImage.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.clipboardData);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(910, 464);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Data Formats";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // clipboardData
            // 
            this.clipboardData.AutoSize = true;
            this.clipboardData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clipboardData.Location = new System.Drawing.Point(3, 3);
            this.clipboardData.Name = "clipboardData";
            this.clipboardData.Size = new System.Drawing.Size(35, 13);
            this.clipboardData.TabIndex = 0;
            this.clipboardData.Text = "label1";
            // 
            // htmlTab
            // 
            this.htmlTab.Controls.Add(this.rtfHTML);
            this.htmlTab.Controls.Add(this.browseHTML);
            this.htmlTab.Location = new System.Drawing.Point(4, 22);
            this.htmlTab.Name = "htmlTab";
            this.htmlTab.Padding = new System.Windows.Forms.Padding(3);
            this.htmlTab.Size = new System.Drawing.Size(910, 464);
            this.htmlTab.TabIndex = 3;
            this.htmlTab.Text = "HTML";
            this.htmlTab.UseVisualStyleBackColor = true;
            this.htmlTab.Click += new System.EventHandler(this.tabPage4_Click);
            // 
            // rtfHTML
            // 
            this.rtfHTML.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfHTML.Location = new System.Drawing.Point(0, 0);
            this.rtfHTML.Name = "rtfHTML";
            this.rtfHTML.Size = new System.Drawing.Size(907, 190);
            this.rtfHTML.TabIndex = 1;
            this.rtfHTML.Text = "";
            // 
            // browseHTML
            // 
            this.browseHTML.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browseHTML.Location = new System.Drawing.Point(3, 196);
            this.browseHTML.MinimumSize = new System.Drawing.Size(20, 20);
            this.browseHTML.Name = "browseHTML";
            this.browseHTML.Size = new System.Drawing.Size(904, 296);
            this.browseHTML.TabIndex = 0;
            // 
            // fmTextboxTab
            // 
            this.fmTextboxTab.Controls.Add(this.fmBrowser);
            this.fmTextboxTab.Controls.Add(this.textBox1);
            this.fmTextboxTab.Controls.Add(this.fmTextBox);
            this.fmTextboxTab.Location = new System.Drawing.Point(4, 22);
            this.fmTextboxTab.Name = "fmTextboxTab";
            this.fmTextboxTab.Padding = new System.Windows.Forms.Padding(3);
            this.fmTextboxTab.Size = new System.Drawing.Size(910, 464);
            this.fmTextboxTab.TabIndex = 4;
            this.fmTextboxTab.Text = "FileMaker";
            this.fmTextboxTab.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(3, 311);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(904, 147);
            this.textBox1.TabIndex = 1;
            // 
            // fmTextBox
            // 
            this.fmTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fmTextBox.Location = new System.Drawing.Point(3, 3);
            this.fmTextBox.Multiline = true;
            this.fmTextBox.Name = "fmTextBox";
            this.fmTextBox.Size = new System.Drawing.Size(904, 167);
            this.fmTextBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fmBrowser
            // 
            this.fmBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fmBrowser.Location = new System.Drawing.Point(3, 177);
            this.fmBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.fmBrowser.Name = "fmBrowser";
            this.fmBrowser.Size = new System.Drawing.Size(904, 128);
            this.fmBrowser.TabIndex = 2;
            // 
            // ClipboardSnoop_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabPanel);
            this.Name = "ClipboardSnoop_Main";
            this.Text = "Clipboard Snoop";
            this.tabPanel.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.clipboardImage)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.htmlTab.ResumeLayout(false);
            this.fmTextboxTab.ResumeLayout(false);
            this.fmTextboxTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox clipboardText;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox clipboardImage;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label clipboardData;
        private System.Windows.Forms.TabPage htmlTab;
        private System.Windows.Forms.WebBrowser browseHTML;
        private System.Windows.Forms.RichTextBox rtfHTML;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage fmTextboxTab;
        private System.Windows.Forms.TextBox fmTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.WebBrowser fmBrowser;

    }
}

