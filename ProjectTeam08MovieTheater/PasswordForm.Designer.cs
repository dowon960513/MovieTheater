namespace ProjectTeam08MovieTheater
{
    partial class PasswordForm
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
            this.labelPasswordMessage = new System.Windows.Forms.Label();
            this.buttonEnterPassword = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPasswordTag = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelPasswordMessage
            // 
            this.labelPasswordMessage.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordMessage.Location = new System.Drawing.Point(51, 20);
            this.labelPasswordMessage.Name = "labelPasswordMessage";
            this.labelPasswordMessage.Size = new System.Drawing.Size(331, 18);
            this.labelPasswordMessage.TabIndex = 7;
            this.labelPasswordMessage.Text = "Incorrect Password. Please type again!";
            this.labelPasswordMessage.Visible = false;
            // 
            // buttonEnterPassword
            // 
            this.buttonEnterPassword.Location = new System.Drawing.Point(150, 129);
            this.buttonEnterPassword.Name = "buttonEnterPassword";
            this.buttonEnterPassword.Size = new System.Drawing.Size(80, 40);
            this.buttonEnterPassword.TabIndex = 6;
            this.buttonEnterPassword.Text = "Enter";
            this.buttonEnterPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(106, 81);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(180, 28);
            this.textBoxPassword.TabIndex = 5;
            // 
            // labelPasswordTag
            // 
            this.labelPasswordTag.AutoSize = true;
            this.labelPasswordTag.Location = new System.Drawing.Point(124, 46);
            this.labelPasswordTag.Name = "labelPasswordTag";
            this.labelPasswordTag.Size = new System.Drawing.Size(144, 18);
            this.labelPasswordTag.TabIndex = 4;
            this.labelPasswordTag.Text = "Enter Password:";
            // 
            // PasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 197);
            this.Controls.Add(this.labelPasswordMessage);
            this.Controls.Add(this.buttonEnterPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPasswordTag);
            this.Name = "PasswordForm";
            this.Text = "Enter Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPasswordMessage;
        private System.Windows.Forms.Button buttonEnterPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelPasswordTag;
    }
}