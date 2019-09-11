namespace ProjectTeam08MovieTheater
{
    partial class ReportForm
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
            this.labelTotalProfit = new System.Windows.Forms.Label();
            this.labelTotalProfitTag = new System.Windows.Forms.Label();
            this.labelBestSellingTag = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.labelOrderTag = new System.Windows.Forms.Label();
            this.listBoxMovie = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSelectedMovieProfit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTotalProfit
            // 
            this.labelTotalProfit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelTotalProfit.Font = new System.Drawing.Font("Gulim", 15F);
            this.labelTotalProfit.Location = new System.Drawing.Point(707, 159);
            this.labelTotalProfit.Name = "labelTotalProfit";
            this.labelTotalProfit.Size = new System.Drawing.Size(169, 42);
            this.labelTotalProfit.TabIndex = 11;
            this.labelTotalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalProfitTag
            // 
            this.labelTotalProfitTag.AutoSize = true;
            this.labelTotalProfitTag.Font = new System.Drawing.Font("Gulim", 15F);
            this.labelTotalProfitTag.Location = new System.Drawing.Point(707, 99);
            this.labelTotalProfitTag.Name = "labelTotalProfitTag";
            this.labelTotalProfitTag.Size = new System.Drawing.Size(174, 30);
            this.labelTotalProfitTag.TabIndex = 10;
            this.labelTotalProfitTag.Text = "Total Profit:";
            // 
            // labelBestSellingTag
            // 
            this.labelBestSellingTag.AutoSize = true;
            this.labelBestSellingTag.Location = new System.Drawing.Point(43, 321);
            this.labelBestSellingTag.Name = "labelBestSellingTag";
            this.labelBestSellingTag.Size = new System.Drawing.Size(112, 18);
            this.labelBestSellingTag.TabIndex = 8;
            this.labelBestSellingTag.Text = "Select Movie";
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(40, 52);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowTemplate.Height = 30;
            this.dataGridViewOrder.Size = new System.Drawing.Size(591, 227);
            this.dataGridViewOrder.TabIndex = 7;
            // 
            // labelOrderTag
            // 
            this.labelOrderTag.AutoSize = true;
            this.labelOrderTag.Location = new System.Drawing.Point(37, 22);
            this.labelOrderTag.Name = "labelOrderTag";
            this.labelOrderTag.Size = new System.Drawing.Size(63, 18);
            this.labelOrderTag.TabIndex = 6;
            this.labelOrderTag.Text = "Orders";
            // 
            // listBoxMovie
            // 
            this.listBoxMovie.FormattingEnabled = true;
            this.listBoxMovie.ItemHeight = 18;
            this.listBoxMovie.Location = new System.Drawing.Point(40, 354);
            this.listBoxMovie.Name = "listBoxMovie";
            this.listBoxMovie.Size = new System.Drawing.Size(239, 94);
            this.listBoxMovie.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gulim", 12F);
            this.label1.Location = new System.Drawing.Point(376, 354);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 24);
            this.label1.TabIndex = 13;
            this.label1.Text = "Selected Movie Profit:";
            // 
            // labelSelectedMovieProfit
            // 
            this.labelSelectedMovieProfit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.labelSelectedMovieProfit.Font = new System.Drawing.Font("Gulim", 15F);
            this.labelSelectedMovieProfit.Location = new System.Drawing.Point(418, 391);
            this.labelSelectedMovieProfit.Name = "labelSelectedMovieProfit";
            this.labelSelectedMovieProfit.Size = new System.Drawing.Size(141, 46);
            this.labelSelectedMovieProfit.TabIndex = 14;
            this.labelSelectedMovieProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 490);
            this.Controls.Add(this.labelSelectedMovieProfit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxMovie);
            this.Controls.Add(this.labelTotalProfit);
            this.Controls.Add(this.labelTotalProfitTag);
            this.Controls.Add(this.labelBestSellingTag);
            this.Controls.Add(this.dataGridViewOrder);
            this.Controls.Add(this.labelOrderTag);
            this.Name = "ReportForm";
            this.Text = "ReportForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTotalProfit;
        private System.Windows.Forms.Label labelTotalProfitTag;
        private System.Windows.Forms.Label labelBestSellingTag;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.Label labelOrderTag;
        private System.Windows.Forms.ListBox listBoxMovie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSelectedMovieProfit;
    }
}