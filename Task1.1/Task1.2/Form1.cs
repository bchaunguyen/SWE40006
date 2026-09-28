using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Incomes;
using Scores;

namespace Task1._2
{
    public partial class Form1 : Form
    {
        private DataTable expenseTable;
        private decimal totalExpense = 0;

        public Form1()
        {
            InitializeComponent();
            SetupExpenseTable();
        }

        private void SetupExpenseTable()
        {
            // Initialize data table schema
            expenseTable = new DataTable();
            expenseTable.Columns.Add("No.", typeof(int));
            expenseTable.Columns.Add("Category", typeof(string));
            expenseTable.Columns.Add("Amount ($)", typeof(string));
            expenseTable.Columns.Add("Note", typeof(string));
            expenseTable.Columns.Add("Date", typeof(string));

            // Populate sample data
            expenseTable.Rows.Add(1, "Food & Dining", "15.00", "Lunch with peers", DateTime.Now.ToShortDateString());
            expenseTable.Rows.Add(2, "Education", "45.00", "SWE40006 textbook", DateTime.Now.ToShortDateString());
            totalExpense = 60.00m;

            Expenses.DataSource = expenseTable;

            // Populate category dropdown options
            Category.Items.AddRange(new string[] { "Food & Dining", "Education", "Entertainment", "Transportation", "Utilities" });
            Category.SelectedIndex = 0;

            UpdateTotalLabel();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(Amount.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Please enter a valid expense amount!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int newId = expenseTable.Rows.Count + 1;
            expenseTable.Rows.Add(newId, Category.SelectedItem.ToString(), amount.ToString("F2"), Note.Text, DateTime.Now.ToShortDateString());

            totalExpense += amount;
            UpdateTotalLabel();

            Amount.Clear();
            Note.Clear();
            MessageBox.Show("Expense added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void UpdateTotalLabel()
        {
            Total.Text = $"Total Expense: ${totalExpense:F2}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}