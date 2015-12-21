using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Presentation;

namespace WindowsFormsApplication1
{
    public partial class EmailGenerator_v : Form
    {
        public event EventHandler pressButton;

        public EmailGenerator_v()
        {
            InitializeComponent();
            
        }

        private void emailB_Click(object sender, EventArgs e)
        {
            if (pressButton != null)
                pressButton(sender, e);
        }

        private void fnameB_Click(object sender, EventArgs e)
        {
            EmailGeneratorEventArgs ev = new EmailGeneratorEventArgs();
            ev.text = this.fnameLabel.Text;
            if (pressButton != null)
                pressButton(sender, ev);
        }

        private void lnameB_Click(object sender, EventArgs e)
        {
            EmailGeneratorEventArgs ev = new EmailGeneratorEventArgs();
            ev.text = this.lnameLabel.Text;
            if (pressButton != null)
                pressButton(sender, ev);
        }

        private void passwordB_Click(object sender, EventArgs e)
        {
            EmailGeneratorEventArgs ev = new EmailGeneratorEventArgs();
            ev.text = this.passwordLabel.Text;
            if (pressButton != null)
                pressButton(sender, ev);
        }

        private void ageB_Click(object sender, EventArgs e)
        {
            EmailGeneratorEventArgs ev = new EmailGeneratorEventArgs();
            ev.text = this.ageLabel.Text;
            if (pressButton != null)
                pressButton(sender, ev);
        }

        private void placeB_Click(object sender, EventArgs e)
        {
            EmailGeneratorEventArgs ev = new EmailGeneratorEventArgs();
            ev.text = this.placeLabel.Text;
            if (pressButton != null)
                pressButton(sender, ev);
        }

        //Change The Label Text
        public void changeEmailLabel(String str)
        {
            this.emailLabel.Text = str;
        }
        public void changeFNameLabel(String str)
        {
            this.fnameLabel.Text = str;
        }
        public void changeLNameLabel(String str)
        {
            this.lnameLabel.Text = str;
        }
        public void changePasswordLabel(String str)
        {
            this.passwordLabel.Text = str;
        }
        public void changeAgeLabel(String str)
        {
            this.ageLabel.Text = str;
        }
        public void changeCityLabel(String str)
        {
            this.placeLabel.Text = str;
        }

        private void langIta_Click(object sender, EventArgs e)
        {
            WorkInProgress wip = new WorkInProgress();
            wip.TopMost = true;
            if (wip.ShowDialog(this) == DialogResult.OK)
            {
                // Read the contents of testDialog's TextBox.
                //this.txtResult.Text = testDialog.TextBox1.Text;
            }
            wip.Dispose();
        }
    }
}
