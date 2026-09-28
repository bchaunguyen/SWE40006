namespace Task1._2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabIncome = new System.Windows.Forms.TabPage();
            this.txtIncomeNote = new System.Windows.Forms.TextBox();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.colIncSource = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colIncDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddIncome = new System.Windows.Forms.Button();
            this.txtIncomeAmount = new System.Windows.Forms.TextBox();
            this.txtIncomeSource = new System.Windows.Forms.TextBox();
            this.tabExpenses = new System.Windows.Forms.TabPage();
            this.lblTotalSpend = new System.Windows.Forms.Label();
            this.txtExpenseNote = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.colExpTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colExpDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddExpense = new System.Windows.Forms.Button();
            this.txtExpenseAmount = new System.Windows.Forms.TextBox();
            this.txtExpenseTitle = new System.Windows.Forms.TextBox();
            this.tabOverview = new System.Windows.Forms.TabPage();
            this.lblWarning = new System.Windows.Forms.Label();
            this.lblExpenseScore = new System.Windows.Forms.Label();
            this.lblNetBalance = new System.Windows.Forms.Label();
            this.lblTotalExpense = new System.Windows.Forms.Label();
            this.lblTotalIncome = new System.Windows.Forms.Label();
            this.tabControlMain.SuspendLayout();
            this.tabIncome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.tabExpenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.tabOverview.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabIncome);
            this.tabControlMain.Controls.Add(this.tabExpenses);
            this.tabControlMain.Controls.Add(this.tabOverview);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(784, 461);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabIncome
            // 
            this.tabIncome.Controls.Add(this.txtIncomeNote);
            this.tabIncome.Controls.Add(this.dgvIncome);
            this.tabIncome.Controls.Add(this.btnAddIncome);
            this.tabIncome.Controls.Add(this.txtIncomeAmount);
            this.tabIncome.Controls.Add(this.txtIncomeSource);
            this.tabIncome.Location = new System.Drawing.Point(4, 26);
            this.tabIncome.Name = "tabIncome";
            this.tabIncome.Padding = new System.Windows.Forms.Padding(10);
            this.tabIncome.Size = new System.Drawing.Size(776, 431);
            this.tabIncome.TabIndex = 0;
            this.tabIncome.Text = "Income Management";
            this.tabIncome.UseVisualStyleBackColor = true;
            // 
            // txtIncomeNote
            // 
            this.txtIncomeNote.Location = new System.Drawing.Point(390, 20);
            this.txtIncomeNote.Name = "txtIncomeNote";
            this.txtIncomeNote.Size = new System.Drawing.Size(180, 25);
            this.txtIncomeNote.TabIndex = 4;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colIncSource,
            this.colIncAmount,
            this.colIncNote,
            this.colIncDate});
            this.dgvIncome.Location = new System.Drawing.Point(20, 60);
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.ReadOnly = true;
            this.dgvIncome.RowTemplate.Height = 25;
            this.dgvIncome.Size = new System.Drawing.Size(735, 350);
            this.dgvIncome.TabIndex = 3;
            // 
            // colIncSource
            // 
            this.colIncSource.HeaderText = "Income Source";
            this.colIncSource.Name = "colIncSource";
            this.colIncSource.ReadOnly = true;
            // 
            // colIncAmount
            // 
            this.colIncAmount.HeaderText = "Amount ($)";
            this.colIncAmount.Name = "colIncAmount";
            this.colIncAmount.ReadOnly = true;
            // 
            // colIncNote
            // 
            this.colIncNote.HeaderText = "Note";
            this.colIncNote.Name = "colIncNote";
            this.colIncNote.ReadOnly = true;
            // 
            // colIncDate
            // 
            this.colIncDate.HeaderText = "Date";
            this.colIncDate.Name = "colIncDate";
            this.colIncDate.ReadOnly = true;
            // 
            // btnAddIncome
            // 
            this.btnAddIncome.Location = new System.Drawing.Point(590, 18);
            this.btnAddIncome.Name = "btnAddIncome";
            this.btnAddIncome.Size = new System.Drawing.Size(120, 28);
            this.btnAddIncome.TabIndex = 2;
            this.btnAddIncome.Text = "Add Income";
            this.btnAddIncome.UseVisualStyleBackColor = true;
            this.btnAddIncome.Click += new System.EventHandler(this.btnAddIncome_Click);
            // 
            // txtIncomeAmount
            // 
            this.txtIncomeAmount.Location = new System.Drawing.Point(210, 20);
            this.txtIncomeAmount.Name = "txtIncomeAmount";
            this.txtIncomeAmount.Size = new System.Drawing.Size(160, 25);
            this.txtIncomeAmount.TabIndex = 1;
            // 
            // txtIncomeSource
            // 
            this.txtIncomeSource.Location = new System.Drawing.Point(20, 20);
            this.txtIncomeSource.Name = "txtIncomeSource";
            this.txtIncomeSource.Size = new System.Drawing.Size(170, 25);
            this.txtIncomeSource.TabIndex = 0;
            // 
            // tabExpenses
            // 
            this.tabExpenses.Controls.Add(this.lblTotalSpend);
            this.tabExpenses.Controls.Add(this.txtExpenseNote);
            this.tabExpenses.Controls.Add(this.cmbCategory);
            this.tabExpenses.Controls.Add(this.dgvExpenses);
            this.tabExpenses.Controls.Add(this.btnAddExpense);
            this.tabExpenses.Controls.Add(this.txtExpenseAmount);
            this.tabExpenses.Controls.Add(this.txtExpenseTitle);
            this.tabExpenses.Location = new System.Drawing.Point(4, 26);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Padding = new System.Windows.Forms.Padding(10);
            this.tabExpenses.Size = new System.Drawing.Size(776, 431);
            this.tabExpenses.TabIndex = 1;
            this.tabExpenses.Text = "Expense Management";
            this.tabExpenses.UseVisualStyleBackColor = true;
            // 
            // lblTotalSpend
            // 
            this.lblTotalSpend.AutoSize = true;
            this.lblTotalSpend.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalSpend.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalSpend.Location = new System.Drawing.Point(540, 395);
            this.lblTotalSpend.Name = "lblTotalSpend";
            this.lblTotalSpend.Size = new System.Drawing.Size(138, 20);
            this.lblTotalSpend.TabIndex = 6;
            this.lblTotalSpend.Text = "Total Spend: $0.00";
            // 
            // txtExpenseNote
            // 
            this.txtExpenseNote.Location = new System.Drawing.Point(450, 20);
            this.txtExpenseNote.Name = "txtExpenseNote";
            this.txtExpenseNote.Size = new System.Drawing.Size(160, 25);
            this.txtExpenseNote.TabIndex = 5;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(160, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(140, 25);
            this.cmbCategory.TabIndex = 4;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colExpTitle,
            this.colExpCategory,
            this.colExpAmount,
            this.colExpNote,
            this.colExpDate});
            this.dgvExpenses.Location = new System.Drawing.Point(20, 60);
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowTemplate.Height = 25;
            this.dgvExpenses.Size = new System.Drawing.Size(735, 320);
            this.dgvExpenses.TabIndex = 3;
            // 
            // colExpTitle
            // 
            this.colExpTitle.HeaderText = "Title";
            this.colExpTitle.Name = "colExpTitle";
            this.colExpTitle.ReadOnly = true;
            // 
            // colExpCategory
            // 
            this.colExpCategory.HeaderText = "Category";
            this.colExpCategory.Name = "colExpCategory";
            this.colExpCategory.ReadOnly = true;
            // 
            // colExpAmount
            // 
            this.colExpAmount.HeaderText = "Amount ($)";
            this.colExpAmount.Name = "colExpAmount";
            this.colExpAmount.ReadOnly = true;
            // 
            // colExpNote
            // 
            this.colExpNote.HeaderText = "Note";
            this.colExpNote.Name = "colExpNote";
            this.colExpNote.ReadOnly = true;
            // 
            // colExpDate
            // 
            this.colExpDate.HeaderText = "Date";
            this.colExpDate.Name = "colExpDate";
            this.colExpDate.ReadOnly = true;
            // 
            // btnAddExpense
            // 
            this.btnAddExpense.Location = new System.Drawing.Point(620, 18);
            this.btnAddExpense.Name = "btnAddExpense";
            this.btnAddExpense.Size = new System.Drawing.Size(135, 28);
            this.btnAddExpense.TabIndex = 2;
            this.btnAddExpense.Text = "Add Expense";
            this.btnAddExpense.UseVisualStyleBackColor = true;
            this.btnAddExpense.Click += new System.EventHandler(this.btnAddExpense_Click);
            // 
            // txtExpenseAmount
            // 
            this.txtExpenseAmount.Location = new System.Drawing.Point(310, 20);
            this.txtExpenseAmount.Name = "txtExpenseAmount";
            this.txtExpenseAmount.Size = new System.Drawing.Size(130, 25);
            this.txtExpenseAmount.TabIndex = 1;
            // 
            // txtExpenseTitle
            // 
            this.txtExpenseTitle.Location = new System.Drawing.Point(20, 20);
            this.txtExpenseTitle.Name = "txtExpenseTitle";
            this.txtExpenseTitle.Size = new System.Drawing.Size(130, 25);
            this.txtExpenseTitle.TabIndex = 0;
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.lblWarning);
            this.tabOverview.Controls.Add(this.lblExpenseScore);
            this.tabOverview.Controls.Add(this.lblNetBalance);
            this.tabOverview.Controls.Add(this.lblTotalExpense);
            this.tabOverview.Controls.Add(this.lblTotalIncome);
            this.tabOverview.Location = new System.Drawing.Point(4, 26);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.Padding = new System.Windows.Forms.Padding(20);
            this.tabOverview.Size = new System.Drawing.Size(776, 431);
            this.tabOverview.TabIndex = 2;
            this.tabOverview.Text = "Expense Score & Overview";
            this.tabOverview.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblWarning.ForeColor = System.Drawing.Color.DarkRed;
            this.lblWarning.Location = new System.Drawing.Point(30, 230);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(710, 60);
            this.lblWarning.TabIndex = 4;
            this.lblWarning.Text = "⚠️ WARNING: Please enter your income first!";
            // 
            // lblExpenseScore
            // 
            this.lblExpenseScore.AutoSize = true;
            this.lblExpenseScore.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblExpenseScore.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblExpenseScore.Location = new System.Drawing.Point(30, 175);
            this.lblExpenseScore.Name = "lblExpenseScore";
            this.lblExpenseScore.Size = new System.Drawing.Size(182, 21);
            this.lblExpenseScore.TabIndex = 3;
            this.lblExpenseScore.Text = "Expense Score: 0 / 100";
            // 
            // lblNetBalance
            // 
            this.lblNetBalance.AutoSize = true;
            this.lblNetBalance.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNetBalance.Location = new System.Drawing.Point(30, 130);
            this.lblNetBalance.Name = "lblNetBalance";
            this.lblNetBalance.Size = new System.Drawing.Size(140, 20);
            this.lblNetBalance.TabIndex = 2;
            this.lblNetBalance.Text = "Net Balance: $0.00";
            // 
            // lblTotalExpense
            // 
            this.lblTotalExpense.AutoSize = true;
            this.lblTotalExpense.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalExpense.Location = new System.Drawing.Point(30, 85);
            this.lblTotalExpense.Name = "lblTotalExpense";
            this.lblTotalExpense.Size = new System.Drawing.Size(141, 20);
            this.lblTotalExpense.TabIndex = 1;
            this.lblTotalExpense.Text = "Total Expense: $0.00";
            // 
            // lblTotalIncome
            // 
            this.lblTotalIncome.AutoSize = true;
            this.lblTotalIncome.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTotalIncome.Location = new System.Drawing.Point(30, 40);
            this.lblTotalIncome.Name = "lblTotalIncome";
            this.lblTotalIncome.Size = new System.Drawing.Size(136, 20);
            this.lblTotalIncome.TabIndex = 0;
            this.lblTotalIncome.Text = "Total Income: $0.00";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Expense Tracker App";
            this.tabControlMain.ResumeLayout(false);
            this.tabIncome.ResumeLayout(false);
            this.tabIncome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.tabExpenses.ResumeLayout(false);
            this.tabExpenses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.tabOverview.ResumeLayout(false);
            this.tabOverview.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabIncome;
        private System.Windows.Forms.TabPage tabExpenses;
        private System.Windows.Forms.TabPage tabOverview;
        private System.Windows.Forms.TextBox txtIncomeSource;
        private System.Windows.Forms.TextBox txtIncomeAmount;
        private System.Windows.Forms.TextBox txtIncomeNote;
        private System.Windows.Forms.Button btnAddIncome;
        private System.Windows.Forms.DataGridView dgvIncome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colIncDate;
        private System.Windows.Forms.TextBox txtExpenseTitle;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtExpenseAmount;
        private System.Windows.Forms.TextBox txtExpenseNote;
        private System.Windows.Forms.Button btnAddExpense;
        private System.Windows.Forms.DataGridView dgvExpenses;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpNote;
        private System.Windows.Forms.DataGridViewTextBoxColumn colExpDate;
        private System.Windows.Forms.Label lblTotalSpend;
        private System.Windows.Forms.Label lblTotalIncome;
        private System.Windows.Forms.Label lblTotalExpense;
        private System.Windows.Forms.Label lblNetBalance;
        private System.Windows.Forms.Label lblExpenseScore;
        private System.Windows.Forms.Label lblWarning;
    }
}