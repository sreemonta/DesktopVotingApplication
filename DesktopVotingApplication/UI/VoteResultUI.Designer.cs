namespace VotingApplication.UI
{
    partial class VoteResultUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.voteResultDataGridView = new System.Windows.Forms.DataGridView();
            this.serialNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitorsNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOfVotesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.resultColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reportButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.voteResultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.voteResultDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(563, 226);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // voteResultDataGridView
            // 
            this.voteResultDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.voteResultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serialNoColumn,
            this.CompetitorsNameColumn,
            this.noOfVotesColumn,
            this.resultColumn});
            this.voteResultDataGridView.Location = new System.Drawing.Point(18, 33);
            this.voteResultDataGridView.Name = "voteResultDataGridView";
            this.voteResultDataGridView.Size = new System.Drawing.Size(525, 162);
            this.voteResultDataGridView.TabIndex = 0;
            // 
            // serialNoColumn
            // 
            this.serialNoColumn.HeaderText = "Serial No.";
            this.serialNoColumn.Name = "serialNoColumn";
            this.serialNoColumn.Width = 80;
            // 
            // CompetitorsNameColumn
            // 
            this.CompetitorsNameColumn.HeaderText = "Competitor’s Name";
            this.CompetitorsNameColumn.Name = "CompetitorsNameColumn";
            this.CompetitorsNameColumn.Width = 150;
            // 
            // noOfVotesColumn
            // 
            this.noOfVotesColumn.HeaderText = "No. of votes (Achieved)";
            this.noOfVotesColumn.Name = "noOfVotesColumn";
            this.noOfVotesColumn.Width = 150;
            // 
            // resultColumn
            // 
            this.resultColumn.HeaderText = "Result";
            this.resultColumn.Name = "resultColumn";
            // 
            // reportButton
            // 
            this.reportButton.Location = new System.Drawing.Point(394, 264);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(75, 23);
            this.reportButton.TabIndex = 1;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = true;
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(478, 264);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(77, 23);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // VoteResultUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(611, 313);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoteResultUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote Result Form";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.voteResultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView voteResultDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitorsNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOfVotesColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn resultColumn;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button closeButton;

    }
}