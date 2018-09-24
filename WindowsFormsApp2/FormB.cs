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
    public partial class FormB : Form
    {
        private Form1 f1;
        private InterfaceAB ifaceAB;

        public FormB(Form1 ParentForm)
        {
            InitializeComponent();
            f1 = ParentForm;
            ifaceAB = ParentForm;
        }


        public void setMessage(String message)
        {
            this.tbFormB.Text = message;
        }

        public String getMessage()
        {

            return this.tbFormB.Text;
        }

            
   
        private void btGetFromParent2_Click(object sender, EventArgs e)
        {
            this.tbFormB.Text = f1.getMessage();
        }

        private void btSendToParent2_Click(object sender, EventArgs e)
        {
             f1.setMessage(tbFormB.Text);
        }

        private void btSendToA_Click(object sender, EventArgs e)
        {
            ifaceAB.sendToA(tbFormB.Text);
        }
    }
}
