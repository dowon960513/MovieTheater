using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectTeam08MovieTheater
{
    public partial class PasswordForm : Form
    {
        //declare password
        private string password = "mmm";

        public PasswordForm()
        {
            InitializeComponent();

            //setting for password textbox
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 14;
            buttonEnterPassword.Click += ButtonEnterPassword_Click;
        }

        private void ButtonEnterPassword_Click(object sender, EventArgs e)
        {
            labelPasswordMessage.Visible = false;
            if (textBoxPassword.Text == password)
            {
                //if password is correct
                ReportForm report = new ReportForm();
                this.Close();

                //open the reportForm
                var openForm = report.ShowDialog();
            }
            else
            {//display the error message and clear the textbox
                labelPasswordMessage.Visible = true;
                textBoxPassword.Text = "";
            }

        }
    }
}
