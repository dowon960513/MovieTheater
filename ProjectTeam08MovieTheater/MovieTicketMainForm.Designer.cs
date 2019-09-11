namespace ProjectTeam08MovieTheater
{
    partial class MovieTicketForm
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
            this.labelAgeMessage = new System.Windows.Forms.Label();
            this.labelTicketMessage = new System.Windows.Forms.Label();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonConfirm = new System.Windows.Forms.Button();
            this.textBoxTicketNum = new System.Windows.Forms.TextBox();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalPriceTag = new System.Windows.Forms.Label();
            this.labelTicketAmountTag = new System.Windows.Forms.Label();
            this.dataGridViewTime = new System.Windows.Forms.DataGridView();
            this.dataGridViewMovie = new System.Windows.Forms.DataGridView();
            this.labelTimeTag = new System.Windows.Forms.Label();
            this.labelMovieTag = new System.Windows.Forms.Label();
            this.textBoxAge = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelAgeTag = new System.Windows.Forms.Label();
            this.labelLnameTag = new System.Windows.Forms.Label();
            this.labelFnameTag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).BeginInit();
            this.SuspendLayout();
            // 
            // labelAgeMessage
            // 
            this.labelAgeMessage.ForeColor = System.Drawing.Color.Red;
            this.labelAgeMessage.Location = new System.Drawing.Point(530, 24);
            this.labelAgeMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeMessage.Name = "labelAgeMessage";
            this.labelAgeMessage.Size = new System.Drawing.Size(64, 17);
            this.labelAgeMessage.TabIndex = 38;
            this.labelAgeMessage.Text = "Invalid age!";
            this.labelAgeMessage.Visible = false;
            // 
            // labelTicketMessage
            // 
            this.labelTicketMessage.ForeColor = System.Drawing.Color.Red;
            this.labelTicketMessage.Location = new System.Drawing.Point(229, 282);
            this.labelTicketMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicketMessage.Name = "labelTicketMessage";
            this.labelTicketMessage.Size = new System.Drawing.Size(117, 26);
            this.labelTicketMessage.TabIndex = 37;
            this.labelTicketMessage.Text = "Invalid Ticket Number!";
            this.labelTicketMessage.Visible = false;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(33, 400);
            this.buttonReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(56, 22);
            this.buttonReport.TabIndex = 36;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(342, 317);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(57, 38);
            this.buttonClear.TabIndex = 35;
            this.buttonClear.Text = "Clear All";
            this.buttonClear.UseVisualStyleBackColor = true;
            // 
            // buttonConfirm
            // 
            this.buttonConfirm.Location = new System.Drawing.Point(213, 317);
            this.buttonConfirm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonConfirm.Name = "buttonConfirm";
            this.buttonConfirm.Size = new System.Drawing.Size(74, 38);
            this.buttonConfirm.TabIndex = 34;
            this.buttonConfirm.Text = "Confirm Order";
            this.buttonConfirm.UseVisualStyleBackColor = true;
            // 
            // textBoxTicketNum
            // 
            this.textBoxTicketNum.Location = new System.Drawing.Point(127, 279);
            this.textBoxTicketNum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxTicketNum.Name = "textBoxTicketNum";
            this.textBoxTicketNum.Size = new System.Drawing.Size(98, 20);
            this.textBoxTicketNum.TabIndex = 33;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTotalPrice.Location = new System.Drawing.Point(493, 282);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(129, 23);
            this.labelTotalPrice.TabIndex = 32;
            // 
            // labelTotalPriceTag
            // 
            this.labelTotalPriceTag.AutoSize = true;
            this.labelTotalPriceTag.Location = new System.Drawing.Point(424, 287);
            this.labelTotalPriceTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalPriceTag.Name = "labelTotalPriceTag";
            this.labelTotalPriceTag.Size = new System.Drawing.Size(64, 13);
            this.labelTotalPriceTag.TabIndex = 31;
            this.labelTotalPriceTag.Text = "Total Price: ";
            // 
            // labelTicketAmountTag
            // 
            this.labelTicketAmountTag.AutoSize = true;
            this.labelTicketAmountTag.Location = new System.Drawing.Point(31, 282);
            this.labelTicketAmountTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTicketAmountTag.Name = "labelTicketAmountTag";
            this.labelTicketAmountTag.Size = new System.Drawing.Size(82, 13);
            this.labelTicketAmountTag.TabIndex = 30;
            this.labelTicketAmountTag.Text = "Ticket Amount: ";
            // 
            // dataGridViewTime
            // 
            this.dataGridViewTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTime.Location = new System.Drawing.Point(429, 90);
            this.dataGridViewTime.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewTime.Name = "dataGridViewTime";
            this.dataGridViewTime.RowTemplate.Height = 30;
            this.dataGridViewTime.Size = new System.Drawing.Size(201, 168);
            this.dataGridViewTime.TabIndex = 29;
            // 
            // dataGridViewMovie
            // 
            this.dataGridViewMovie.AllowUserToAddRows = false;
            this.dataGridViewMovie.AllowUserToDeleteRows = false;
            this.dataGridViewMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMovie.Location = new System.Drawing.Point(33, 90);
            this.dataGridViewMovie.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMovie.Name = "dataGridViewMovie";
            this.dataGridViewMovie.RowTemplate.Height = 30;
            this.dataGridViewMovie.Size = new System.Drawing.Size(366, 168);
            this.dataGridViewMovie.TabIndex = 28;
            // 
            // labelTimeTag
            // 
            this.labelTimeTag.AutoSize = true;
            this.labelTimeTag.Location = new System.Drawing.Point(441, 62);
            this.labelTimeTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTimeTag.Name = "labelTimeTag";
            this.labelTimeTag.Size = new System.Drawing.Size(69, 13);
            this.labelTimeTag.TabIndex = 27;
            this.labelTimeTag.Text = "Select Time: ";
            // 
            // labelMovieTag
            // 
            this.labelMovieTag.AutoSize = true;
            this.labelMovieTag.Location = new System.Drawing.Point(31, 62);
            this.labelMovieTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMovieTag.Name = "labelMovieTag";
            this.labelMovieTag.Size = new System.Drawing.Size(75, 13);
            this.labelMovieTag.TabIndex = 26;
            this.labelMovieTag.Text = "Select Movie: ";
            // 
            // textBoxAge
            // 
            this.textBoxAge.Location = new System.Drawing.Point(463, 21);
            this.textBoxAge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxAge.Name = "textBoxAge";
            this.textBoxAge.Size = new System.Drawing.Size(62, 20);
            this.textBoxAge.TabIndex = 25;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(304, 20);
            this.textBoxLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(96, 20);
            this.textBoxLastName.TabIndex = 24;
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(113, 17);
            this.textBoxFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(96, 20);
            this.textBoxFirstName.TabIndex = 23;
            // 
            // labelAgeTag
            // 
            this.labelAgeTag.AutoSize = true;
            this.labelAgeTag.Location = new System.Drawing.Point(425, 25);
            this.labelAgeTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAgeTag.Name = "labelAgeTag";
            this.labelAgeTag.Size = new System.Drawing.Size(32, 13);
            this.labelAgeTag.TabIndex = 22;
            this.labelAgeTag.Text = "Age: ";
            // 
            // labelLnameTag
            // 
            this.labelLnameTag.AutoSize = true;
            this.labelLnameTag.Location = new System.Drawing.Point(236, 22);
            this.labelLnameTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelLnameTag.Name = "labelLnameTag";
            this.labelLnameTag.Size = new System.Drawing.Size(64, 13);
            this.labelLnameTag.TabIndex = 21;
            this.labelLnameTag.Text = "Last Name: ";
            // 
            // labelFnameTag
            // 
            this.labelFnameTag.AutoSize = true;
            this.labelFnameTag.Location = new System.Drawing.Point(46, 24);
            this.labelFnameTag.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFnameTag.Name = "labelFnameTag";
            this.labelFnameTag.Size = new System.Drawing.Size(63, 13);
            this.labelFnameTag.TabIndex = 20;
            this.labelFnameTag.Text = "First Name: ";
            // 
            // MovieTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 442);
            this.Controls.Add(this.labelAgeMessage);
            this.Controls.Add(this.labelTicketMessage);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonConfirm);
            this.Controls.Add(this.textBoxTicketNum);
            this.Controls.Add(this.labelTotalPrice);
            this.Controls.Add(this.labelTotalPriceTag);
            this.Controls.Add(this.labelTicketAmountTag);
            this.Controls.Add(this.dataGridViewTime);
            this.Controls.Add(this.dataGridViewMovie);
            this.Controls.Add(this.labelTimeTag);
            this.Controls.Add(this.labelMovieTag);
            this.Controls.Add(this.textBoxAge);
            this.Controls.Add(this.textBoxLastName);
            this.Controls.Add(this.textBoxFirstName);
            this.Controls.Add(this.labelAgeTag);
            this.Controls.Add(this.labelLnameTag);
            this.Controls.Add(this.labelFnameTag);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MovieTicketForm";
            this.Text = "MovieTicketMainForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMovie)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelAgeMessage;
        private System.Windows.Forms.Label labelTicketMessage;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonConfirm;
        private System.Windows.Forms.TextBox textBoxTicketNum;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalPriceTag;
        private System.Windows.Forms.Label labelTicketAmountTag;
        private System.Windows.Forms.DataGridView dataGridViewTime;
        private System.Windows.Forms.DataGridView dataGridViewMovie;
        private System.Windows.Forms.Label labelTimeTag;
        private System.Windows.Forms.Label labelMovieTag;
        private System.Windows.Forms.TextBox textBoxAge;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelAgeTag;
        private System.Windows.Forms.Label labelLnameTag;
        private System.Windows.Forms.Label labelFnameTag;
    }
}

