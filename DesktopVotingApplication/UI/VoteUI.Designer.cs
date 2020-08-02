namespace VotingApplication.UI
{
    partial class VoteUI
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
            this.competitorCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.castButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.competitorCheckedListBox);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 124);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // competitorCheckedListBox
            // 
            this.competitorCheckedListBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.competitorCheckedListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.competitorCheckedListBox.CheckOnClick = true;
            this.competitorCheckedListBox.FormattingEnabled = true;
            this.competitorCheckedListBox.Location = new System.Drawing.Point(24, 20);
            this.competitorCheckedListBox.Name = "competitorCheckedListBox";
            this.competitorCheckedListBox.Size = new System.Drawing.Size(203, 96);
            this.competitorCheckedListBox.TabIndex = 0;
            this.competitorCheckedListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.competitorCheckedListBox_ItemCheck);
            // 
            // castButton
            // 
            this.castButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.castButton.Location = new System.Drawing.Point(220, 156);
            this.castButton.Name = "castButton";
            this.castButton.Size = new System.Drawing.Size(75, 23);
            this.castButton.TabIndex = 1;
            this.castButton.Text = "Cast";
            this.castButton.UseVisualStyleBackColor = true;
            this.castButton.Click += new System.EventHandler(this.castButton_Click);
            // 
            // VoteUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(319, 204);
            this.Controls.Add(this.castButton);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VoteUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vote Form";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckedListBox competitorCheckedListBox;
        private System.Windows.Forms.Button castButton;
    }
}