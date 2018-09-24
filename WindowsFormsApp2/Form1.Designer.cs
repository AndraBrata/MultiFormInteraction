namespace WindowsFormsApp2
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximisedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideFormBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showBToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sendToAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mDIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.form2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizedToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.changeTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ambilTextToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblForm1 = new System.Windows.Forms.Label();
            this.formAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.sDIToolStripMenuItem,
            this.mDIToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(775, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // sDIToolStripMenuItem
            // 
            this.sDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formToolStripMenuItem,
            this.hideFormBToolStripMenuItem,
            this.toolStripSeparator1,
            this.sendToAToolStripMenuItem,
            this.sendToBToolStripMenuItem});
            this.sDIToolStripMenuItem.Name = "sDIToolStripMenuItem";
            this.sDIToolStripMenuItem.Size = new System.Drawing.Size(36, 20);
            this.sDIToolStripMenuItem.Text = "SDI";
            // 
            // formToolStripMenuItem
            // 
            this.formToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.maximisedToolStripMenuItem,
            this.minimizedToolStripMenuItem,
            this.changeTextToolStripMenuItem,
            this.ambilTextToolStripMenuItem});
            this.formToolStripMenuItem.Name = "formToolStripMenuItem";
            this.formToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.formToolStripMenuItem.Text = "Form A";
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // maximisedToolStripMenuItem
            // 
            this.maximisedToolStripMenuItem.Name = "maximisedToolStripMenuItem";
            this.maximisedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.maximisedToolStripMenuItem.Text = "Maximised";
            this.maximisedToolStripMenuItem.Click += new System.EventHandler(this.maximisedToolStripMenuItem_Click);
            // 
            // minimizedToolStripMenuItem
            // 
            this.minimizedToolStripMenuItem.Name = "minimizedToolStripMenuItem";
            this.minimizedToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.minimizedToolStripMenuItem.Text = "Minimized";
            this.minimizedToolStripMenuItem.Click += new System.EventHandler(this.minimizedToolStripMenuItem_Click);
            // 
            // changeTextToolStripMenuItem
            // 
            this.changeTextToolStripMenuItem.Name = "changeTextToolStripMenuItem";
            this.changeTextToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.changeTextToolStripMenuItem.Text = "Change Text";
            this.changeTextToolStripMenuItem.Click += new System.EventHandler(this.changeTextToolStripMenuItem_Click);
            // 
            // ambilTextToolStripMenuItem
            // 
            this.ambilTextToolStripMenuItem.Name = "ambilTextToolStripMenuItem";
            this.ambilTextToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.ambilTextToolStripMenuItem.Text = "Get Text From";
            this.ambilTextToolStripMenuItem.Click += new System.EventHandler(this.ambilTextToolStripMenuItem_Click);
            // 
            // hideFormBToolStripMenuItem
            // 
            this.hideFormBToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showBToolStripMenuItem2,
            this.hideBToolStripMenuItem});
            this.hideFormBToolStripMenuItem.Name = "hideFormBToolStripMenuItem";
            this.hideFormBToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.hideFormBToolStripMenuItem.Text = "Form B";
            // 
            // showBToolStripMenuItem2
            // 
            this.showBToolStripMenuItem2.Name = "showBToolStripMenuItem2";
            this.showBToolStripMenuItem2.Size = new System.Drawing.Size(113, 22);
            this.showBToolStripMenuItem2.Text = "Show B";
            this.showBToolStripMenuItem2.Click += new System.EventHandler(this.showBToolStripMenuItem2_Click);
            // 
            // hideBToolStripMenuItem
            // 
            this.hideBToolStripMenuItem.Name = "hideBToolStripMenuItem";
            this.hideBToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.hideBToolStripMenuItem.Text = "Hide B";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(122, 6);
            // 
            // sendToAToolStripMenuItem
            // 
            this.sendToAToolStripMenuItem.Name = "sendToAToolStripMenuItem";
            this.sendToAToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sendToAToolStripMenuItem.Text = "Send to A";
            this.sendToAToolStripMenuItem.Click += new System.EventHandler(this.sendToAToolStripMenuItem_Click);
            // 
            // sendToBToolStripMenuItem
            // 
            this.sendToBToolStripMenuItem.Name = "sendToBToolStripMenuItem";
            this.sendToBToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.sendToBToolStripMenuItem.Text = "Send to B";
            this.sendToBToolStripMenuItem.Click += new System.EventHandler(this.sendToBToolStripMenuItem_Click);
            // 
            // mDIToolStripMenuItem
            // 
            this.mDIToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.form2ToolStripMenuItem,
            this.formAToolStripMenuItem});
            this.mDIToolStripMenuItem.Name = "mDIToolStripMenuItem";
            this.mDIToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.mDIToolStripMenuItem.Text = "MDI";
            // 
            // form2ToolStripMenuItem
            // 
            this.form2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem1,
            this.hideToolStripMenuItem1,
            this.maximizedToolStripMenuItem,
            this.minimizedToolStripMenuItem1,
            this.changeTextToolStripMenuItem1,
            this.ambilTextToolStripMenuItem1});
            this.form2ToolStripMenuItem.Name = "form2ToolStripMenuItem";
            this.form2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.form2ToolStripMenuItem.Text = "Form B";
            // 
            // showToolStripMenuItem1
            // 
            this.showToolStripMenuItem1.Name = "showToolStripMenuItem1";
            this.showToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.showToolStripMenuItem1.Text = "Show";
            this.showToolStripMenuItem1.Click += new System.EventHandler(this.showToolStripMenuItem1_Click);
            // 
            // hideToolStripMenuItem1
            // 
            this.hideToolStripMenuItem1.Name = "hideToolStripMenuItem1";
            this.hideToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.hideToolStripMenuItem1.Text = "Hide";
            this.hideToolStripMenuItem1.Click += new System.EventHandler(this.hideToolStripMenuItem1_Click);
            // 
            // maximizedToolStripMenuItem
            // 
            this.maximizedToolStripMenuItem.Name = "maximizedToolStripMenuItem";
            this.maximizedToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.maximizedToolStripMenuItem.Text = "Maximized";
            this.maximizedToolStripMenuItem.Click += new System.EventHandler(this.maximizedToolStripMenuItem_Click);
            // 
            // minimizedToolStripMenuItem1
            // 
            this.minimizedToolStripMenuItem1.Name = "minimizedToolStripMenuItem1";
            this.minimizedToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.minimizedToolStripMenuItem1.Text = "Minimized";
            this.minimizedToolStripMenuItem1.Click += new System.EventHandler(this.minimizedToolStripMenuItem1_Click);
            // 
            // changeTextToolStripMenuItem1
            // 
            this.changeTextToolStripMenuItem1.Name = "changeTextToolStripMenuItem1";
            this.changeTextToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.changeTextToolStripMenuItem1.Text = "Change Text";
            // 
            // ambilTextToolStripMenuItem1
            // 
            this.ambilTextToolStripMenuItem1.Name = "ambilTextToolStripMenuItem1";
            this.ambilTextToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.ambilTextToolStripMenuItem1.Text = "Ambil Text";
            // 
            // lblForm1
            // 
            this.lblForm1.AutoSize = true;
            this.lblForm1.Location = new System.Drawing.Point(12, 50);
            this.lblForm1.Name = "lblForm1";
            this.lblForm1.Size = new System.Drawing.Size(91, 13);
            this.lblForm1.TabIndex = 1;
            this.lblForm1.Text = "Text in Main Form";
            // 
            // formAToolStripMenuItem
            // 
            this.formAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showAToolStripMenuItem,
            this.hideAToolStripMenuItem});
            this.formAToolStripMenuItem.Name = "formAToolStripMenuItem";
            this.formAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.formAToolStripMenuItem.Text = "Form A";
            // 
            // showAToolStripMenuItem
            // 
            this.showAToolStripMenuItem.Name = "showAToolStripMenuItem";
            this.showAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showAToolStripMenuItem.Text = "Show A";
            this.showAToolStripMenuItem.Click += new System.EventHandler(this.showAToolStripMenuItem_Click);
            // 
            // hideAToolStripMenuItem
            // 
            this.hideAToolStripMenuItem.Name = "hideAToolStripMenuItem";
            this.hideAToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.hideAToolStripMenuItem.Text = "Hide A";
            this.hideAToolStripMenuItem.Click += new System.EventHandler(this.hideAToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 441);
            this.Controls.Add(this.lblForm1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Windows Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Label lblForm1;
        private System.Windows.Forms.ToolStripMenuItem sDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximisedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambilTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mDIToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem form2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem maximizedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minimizedToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ambilTextToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem hideFormBToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sendToAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showBToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem hideBToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideAToolStripMenuItem;
    }
}

