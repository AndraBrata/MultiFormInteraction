namespace WindowsFormsApp2
{
    partial class FormB
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
            this.btGetFromParent2 = new System.Windows.Forms.Button();
            this.btSendToA = new System.Windows.Forms.Button();
            this.tbFormB = new System.Windows.Forms.TextBox();
            this.btSendToParent2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btGetFromParent2
            // 
            this.btGetFromParent2.Location = new System.Drawing.Point(36, 84);
            this.btGetFromParent2.Margin = new System.Windows.Forms.Padding(2);
            this.btGetFromParent2.Name = "btGetFromParent2";
            this.btGetFromParent2.Size = new System.Drawing.Size(108, 30);
            this.btGetFromParent2.TabIndex = 0;
            this.btGetFromParent2.Text = "Get From Parent";
            this.btGetFromParent2.UseVisualStyleBackColor = true;
            this.btGetFromParent2.Click += new System.EventHandler(this.btGetFromParent2_Click);
            // 
            // btSendToA
            // 
            this.btSendToA.Location = new System.Drawing.Point(278, 84);
            this.btSendToA.Margin = new System.Windows.Forms.Padding(2);
            this.btSendToA.Name = "btSendToA";
            this.btSendToA.Size = new System.Drawing.Size(105, 30);
            this.btSendToA.TabIndex = 5;
            this.btSendToA.Text = "Send To A";
            this.btSendToA.UseVisualStyleBackColor = true;
            this.btSendToA.Click += new System.EventHandler(this.btSendToA_Click);
            // 
            // tbFormB
            // 
            this.tbFormB.Location = new System.Drawing.Point(36, 43);
            this.tbFormB.Margin = new System.Windows.Forms.Padding(2);
            this.tbFormB.Name = "tbFormB";
            this.tbFormB.Size = new System.Drawing.Size(347, 20);
            this.tbFormB.TabIndex = 4;
            // 
            // btSendToParent2
            // 
            this.btSendToParent2.Location = new System.Drawing.Point(159, 84);
            this.btSendToParent2.Margin = new System.Windows.Forms.Padding(2);
            this.btSendToParent2.Name = "btSendToParent2";
            this.btSendToParent2.Size = new System.Drawing.Size(105, 30);
            this.btSendToParent2.TabIndex = 3;
            this.btSendToParent2.Text = "Send To Parent";
            this.btSendToParent2.UseVisualStyleBackColor = true;
            this.btSendToParent2.Click += new System.EventHandler(this.btSendToParent2_Click);
            // 
            // FormB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 136);
            this.Controls.Add(this.btSendToA);
            this.Controls.Add(this.tbFormB);
            this.Controls.Add(this.btSendToParent2);
            this.Controls.Add(this.btGetFromParent2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormB";
            this.Text = "Form B";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGetFromParent2;
        private System.Windows.Forms.Button btSendToA;
        private System.Windows.Forms.TextBox tbFormB;
        private System.Windows.Forms.Button btSendToParent2;
    }
}