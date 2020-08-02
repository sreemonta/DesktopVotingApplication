using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using VotingApplication.Library.BLL;
using VotingApplication.Library.Models;
using Application=System.Windows.Forms.Application;

namespace VotingApplication.UI
{
    public partial class VoteResultUI : Form
    {
        private List<Competitor> competitors = null;

        public VoteResultUI()
        {
            InitializeComponent();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            int count = 0;
            competitors = new List<Competitor>();
            CommissionerManager commissionerManager = new CommissionerManager();
            competitors = commissionerManager.GetVoteResult();

            foreach (Competitor competitor in competitors)
            {
                voteResultDataGridView.Rows.Add();
                voteResultDataGridView.Rows[count].Cells[0].Value = (count+1).ToString();
                voteResultDataGridView.Rows[count].Cells[1].Value = competitor.Name;
                voteResultDataGridView.Rows[count].Cells[2].Value = competitor.NoOfVote.ToString();
                voteResultDataGridView.Rows[count].Cells[3].Value = competitor.Status;
                count++;
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            int ColumnIndex = 0;
            
            ApplicationClass excelDoc = new ApplicationClass();

            excelDoc.Workbooks.Add(1);
            excelDoc.Columns.ColumnWidth = 20;
            foreach (DataGridViewColumn column in voteResultDataGridView.Columns)
            {
                ColumnIndex++;
                excelDoc.Cells[1, ColumnIndex] = column.HeaderText;
            }
            int rowIndex = 0;

            foreach (DataGridViewRow row in voteResultDataGridView.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    rowIndex++;
                    for (ColumnIndex = 0; ColumnIndex < 4; )
                    {
                        ColumnIndex++;
                        excelDoc.Cells[rowIndex + 1, ColumnIndex] = row.Cells[ColumnIndex - 1].Value.ToString();
                    }
                }
            }

            excelDoc.Visible = true;
            Worksheet worksheet = (Worksheet)excelDoc.ActiveSheet;
            worksheet.Activate();
            excelDoc.ActiveWorkbook.SaveCopyAs(Application.StartupPath + "\\Reports\\Vote_RelultExcelFile.xls");
            excelDoc.ActiveWorkbook.Saved = true;
            //excelDoc.Quit();
        }

       
    }
}
