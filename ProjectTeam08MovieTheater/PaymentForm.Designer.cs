namespace ProjectTeam08MovieTheater
{
    partial class PaymentForm
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
            this.labelCorrectCreditMessage = new System.Windows.Forms.Label();
            this.labelCreditCardMessage = new System.Windows.Forms.Label();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxCreditCardNum = new System.Windows.Forms.TextBox();
            this.labelCreditCardNumTag = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelCorrectCreditMessage
            // 
            this.labelCorrectCreditMessage.ForeColor = System.Drawing.Color.Green;
            this.labelCorrectCreditMessage.Location = new System.Drawing.Point(268, 116);
            this.labelCorrectCreditMessage.Name = "labelCorrectCreditMessage";
            this.labelCorrectCreditMessage.Size = new System.Drawing.Size(241, 25);
            this.labelCorrectCreditMessage.TabIndex = 9;
            this.labelCorrectCreditMessage.Text = "Correct Credit Card!";
            this.labelCorrectCreditMessage.Visible = false;
            // 
            // labelCreditCardMessage
            // 
            this.labelCreditCardMessage.ForeColor = System.Drawing.Color.Red;
            this.labelCreditCardMessage.Location = new System.Drawing.Point(243, 115);
            this.labelCreditCardMessage.Name = "labelCreditCardMessage";
            this.labelCreditCardMessage.Size = new System.Drawing.Size(241, 25);
            this.labelCreditCardMessage.TabIndex = 8;
            this.labelCreditCardMessage.Text = "Invalid Credit Card Number!";
            this.labelCreditCardMessage.Visible = false;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(209, 188);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(98, 43);
            this.buttonConfirm.TabIndex = 7;
            this.buttonConfirm.Text = "Confirm";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // textBoxCreditCardNum
            // 
            this.textBoxCreditCardNum.Location = new System.Drawing.Point(330, 56);
            this.textBoxCreditCardNum.Name = "textBoxCreditCardNum";
            this.textBoxCreditCardNum.Size = new System.Drawing.Size(316, 28);
            this.textBoxCreditCardNum.TabIndex = 6;
            // 
            // labelCreditCardNumTag
            // 
            this.labelCreditCardNumTag.AutoSize = true;
            this.labelCreditCardNumTag.Location = new System.Drawing.Point(79, 61);
            this.labelCreditCardNumTag.Name = "labelCreditCardNumTag";
            this.labelCreditCardNumTag.Size = new System.Drawing.Size(257, 18);
            this.labelCreditCardNumTag.TabIndex = 5;
            this.labelCreditCardNumTag.Text = "Credit Card Number (16-digit): ";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(384, 188);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(98, 43);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // PaymentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 271);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelCorrectCreditMessage);
            this.Controls.Add(this.labelCreditCardMessage);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxCreditCardNum);
            this.Controls.Add(this.labelCreditCardNumTag);
            this.Name = "PaymentForm";
            this.Text = "PaymentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCorrectCreditMessage;
        private System.Windows.Forms.Label labelCreditCardMessage;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxCreditCardNum;
        private System.Windows.Forms.Label labelCreditCardNumTag;
        private System.Windows.Forms.Button buttonCancel;
    }
}