using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Income;
using Score;

namespace ETA
{
    public partial class Form1 : Form
    {
        private decimal totalIncome = 0;
        private decimal totalExpense = 0;

      
        private readonly IncomeProcessor incomeProc = new IncomeProcessor();
        private readonly ScoreCalculator scoreCalc = new ScoreCalculator();

        public Form1()
        {
            InitializeComponent();
            SetupCategoryDropdown();
        }

        private void SetupCategoryDropdown()
        {
            cmbCategory.Items.Clear();
            cmbCategory.Items.AddRange(new string[] {
                "Food & Dining",
                "Rent & Utilities",
                "Shopping",
                "Transportation",
                "Entertainment",
                "Other"
            });
            cmbCategory.SelectedIndex = 0;
        }

        // add income
        private void btnAddIncome_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtIncomeAmount.Text, out decimal amount) && amount > 0)
            {
                totalIncome += amount;

                string source = txtIncomeSource.Text;
                string note = txtIncomeNote.Text;

                dgvIncome.Rows.Add(source, amount, note, DateTime.Now.ToString("dd/MM/yyyy"));

                txtIncomeSource.Clear();
                txtIncomeAmount.Clear();
                txtIncomeNote.Clear();

                UpdateOverview();
                MessageBox.Show("Income added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid income amount!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // add expense
        private void btnAddExpense_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtExpenseAmount.Text, out decimal amount) && amount > 0)
            {
                totalExpense += amount;

                string category = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : "Other";
                string title = string.IsNullOrWhiteSpace(txtExpenseTitle.Text) ? category : txtExpenseTitle.Text;
                string note = txtExpenseNote.Text;

                dgvExpenses.Rows.Add(title, category, amount, note, DateTime.Now.ToString("dd/MM/yyyy"));

                txtExpenseTitle.Clear();
                txtExpenseAmount.Clear();
                txtExpenseNote.Clear();

                lblTotalSpend.Text = $"Total Spend: ${totalExpense:N2}";

                UpdateOverview();
                MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please enter a valid expense amount!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Overview
        private void UpdateOverview()
        {
            //call Income to get Net Balance
            decimal netBalance = incomeProc.CalculateBalance(totalIncome, totalExpense);

            // call Score to get Warning
            string warningMsg = scoreCalc.GetSpendingWarning(totalIncome, totalExpense);
            int score = scoreCalc.CalculateScore(totalIncome, totalExpense);

            lblTotalIncome.Text = $"Total Income: ${totalIncome:N2}";
            lblTotalExpense.Text = $"Total Expense: ${totalExpense:N2}";
            lblNetBalance.Text = $"Net Balance: ${netBalance:N2}";
            lblExpenseScore.Text = $"Expense Score: {score} / 100";
            lblWarning.Text = warningMsg;
        }
    }
}