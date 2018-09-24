namespace WindowsFormsApp2
{
    partial class FormA
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
            this.btSendToParent = new System.Windows.Forms.Button();
            this.tbFormA = new System.Windows.Forms.TextBox();
            this.btSendToB = new System.Windows.Forms.Button();
            this.btGetFromParent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btSendToParent
            // 
            this.btSendToParent.Location = new System.Drawing.Point(143, 67);
            this.btSendToParent.Margin = new System.Windows.Forms.Padding(2);
            this.btSendToParent.Name = "btSendToParent";
            this.btSendToParent.Size = new System.Drawing.Size(105, 30);
            this.btSendToParent.TabIndex = 0;
            this.btSendToParent.Text = "Send To Parent";
            this.btSendToParent.UseVisualStyleBackColor = true;
            this.btSendToParent.Click += new System.EventHandler(this.btSendToParent_Click);
            // 
            // tbFormA
            // 
            this.tbFormA.Location = new System.Drawing.Point(10, 31);
            this.tbFormA.Margin = new System.Windows.Forms.Padding(2);
            this.tbFormA.Name = "tbFormA";
            this.tbFormA.Size = new System.Drawing.Size(347, 20);
            this.tbFormA.TabIndex = 1;
            // 
            // btSendToB
            // 
            this.btSendToB.Location = new System.Drawing.Point(252, 67);
            this.btSendToB.Margin = new System.Windows.Forms.Padding(2);
            this.btSendToB.Name = "btSendToB";
            this.btSendToB.Size = new System.Drawing.Size(105, 30);
            this.btSendToB.TabIndex = 2;
            this.btSendToB.Text = "Send To B";
            this.btSendToB.UseVisualStyleBackColor = true;
            this.btSendToB.Click += new System.EventHandler(this.btSendToB_Click);
            // 
            // btGetFromParent
            // 
            this.btGetFromParent.Location = new System.Drawing.Point(34, 67);
            this.btGetFromParent.Margin = new System.Windows.Forms.Padding(2);
            this.btGetFromParent.Name = "btGetFromParent";
            this.btGetFromParent.Size = new System.Drawing.Size(105, 30);
            this.btGetFromParent.TabIndex = 3;
            this.btGetFromParent.Text = "Get From Parent";
            this.btGetFromParent.UseVisualStyleBackColor = true;
            this.btGetFromParent.Click += new System.EventHandler(this.btGetFromParent_Click);
            // 
            // FormA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 149);
            this.Controls.Add(this.btGetFromParent);
            this.Controls.Add(this.btSendToB);
            this.Controls.Add(this.tbFormA);
            this.Controls.Add(this.btSendToParent);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormA";
            this.Text = "Form A";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btSendToParent;
        private System.Windows.Forms.TextBox tbFormA;
        private System.Windows.Forms.Button btSendToB;
        private System.Windows.Forms.Button btGetFromParent;
    }
}