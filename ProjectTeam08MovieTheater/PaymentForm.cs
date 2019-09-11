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
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();

            //add event handlers
            textBoxCreditCardNum.TextChanged += TextBoxCreditCardNum_TextChanged;
            buttonConfirm.Click += ButtonConfirm_Click;
            buttonCancel.Click += ButtonCancel_Click;
        }

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            //when the user clicks cancel button
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            //if the user press OK
            this.DialogResult = DialogResult.OK;

            //when the correct error message is visible == correct number typed
            if (labelCorrectCreditMessage.Visible)
            {
                //display transaction complete message
                MessageBox.Show("Payment Complete\n   Enjoy the Movies!");
                this.Close();
            }
            else
            {
                //if user clicks confirm when having invalid card number in the textbox
                MessageBox.Show("Please check for invalid credit card number.");
            }

        }

        private void TextBoxCreditCardNum_TextChanged(object sender, EventArgs e)
        {
            //to catch invalid card number: ex) String value
            try
            {
                long creditNum = long.Parse(textBoxCreditCardNum.Text);
                labelCreditCardMessage.Visible = false;
                labelCorrectCreditMessage.Visible = false;

                //correct card number and length
                if (creditNum.ToString().Length == 16)
                {
                    labelCreditCardMessage.Visible = false;
                    labelCorrectCreditMessage.Visible = true;
                }
                //incorrect card number
                else
                {
                    labelCreditCardMessage.Visible = true;
                    labelCorrectCreditMessage.Visible = false;
                }
            }
            //fail to parse the data
            catch
            {
                labelCreditCardMessage.Visible = true;
                labelCorrectCreditMessage.Visible = false; ;
            }
            //when the textbox is empty, disable messages
            if (textBoxCreditCardNum.Text == "")
            {
                labelCorrectCreditMessage.Visible = false;
                labelCreditCardMessage.Visible = false;
            }
        }




    }
}
