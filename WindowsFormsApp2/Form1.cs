using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form, InterfaceAB
    {
        public static FormA formA;
        public static FormB formB;
        

       

        public Form1()
        {
            InitializeComponent();
            
            //SDI
                     
            formA = new FormA(this);

            formB = new FormB(this);
           

        }

        public void setMessage(String message)
        {
           
            this.lblForm1.Text = message;
        }



        public string getMessage()
        {
            return this.lblForm1.Text;
        }


        private void formToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (formA != null)
            {
                formA.Hide();
            }

        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formA != null)
            {
                //this.Hide();
                formA.Show();
               // formA.ShowDialog();
            }
        }

        private void maximisedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formA.WindowState=FormWindowState.Maximized;
        }

        private void minimizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formA.WindowState = FormWindowState.Minimized;
        }

        private void changeTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formA.Text = lblForm1.Text;
        }

        private void ambilTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblForm1.Text = formA.getMessage();
        }

        private void showToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MDI
            formB.MdiParent = this;
            formB.Show();
        }

        private void hideToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formB.Hide();
        }

        private void maximizedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formB.WindowState = FormWindowState.Maximized;
        }

        private void minimizedToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formB.WindowState = FormWindowState.Minimized;
        }

        private void changeTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            formB.Text= lblForm1.Text;
        }

        private void ambilTextToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            lblForm1.Text = formB.Text;
        }

        private void showAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // MDI
            formA.MdiParent = this;
            formA.Show();
        }

        private void hideAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formA.Hide();
        }


        private void ambilDariForm3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
                  
        private void sendToBToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sendToAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String message = this.lblForm1.Text;

            if (formA != null)
            {
                formA.setMessage(message);
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showBToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            formB.Show();
        }

        public void sendToA(string message)
        {

            if (formA != null)
            {
                formA.setMessage(message);
            }

                       
        }

        public void sendToB(string message)
        {
            if (formB != null)
            {
                formB.setMessage(message);
            }
            
                       
        }


    }
}
