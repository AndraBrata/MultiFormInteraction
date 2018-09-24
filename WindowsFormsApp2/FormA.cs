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
    public partial class FormA : Form
    {
        private Form1 f1;
        private InterfaceAB ifaceAB;


        public FormA(Form1 Parentform)
        {
            InitializeComponent();
            f1 = Parentform;
            this.ifaceAB  = Parentform;
            
        }

        public void setMessage (String message)
        {
            this.tbFormA.Text = message;
        }

        public String getMessage()
        {

            return this.tbFormA.Text;
        }



        private void btSendToParent_Click(object sender, EventArgs e)
        {
            f1.setMessage(tbFormA.Text);
               
        }

        private void btGetFromParent_Click(object sender, EventArgs e)
        {
            this.tbFormA.Text = f1.getMessage();
        }

        private void btSendToB_Click(object sender, EventArgs e)
        {
            this.ifaceAB.sendToB(tbFormA.Text);
           
        }
    }
}
