using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParrisBudget
{
    public partial class FormNewBudget : Form
    {
        private int _incomeTotal = 0;
        private int _expenseTotal = 0;

        public FormNewBudget()
        {
            InitializeComponent();

            Budget budget = Data.GetBudget();

            AndreasIncomeTextBox.Text = budget.AndreasIncome.ToString();
            JeremysIncomeTextBox.Text = budget.JeremysIncome.ToString();
            RentIncomeTextBox.Text = budget.RentIncome.ToString();
            RentExpenseTextBox.Text = budget.RentExpense.ToString();
            MortgageTextBox.Text = budget.Mortage.ToString();
            IncomeTotalLabel.Text = budget.IncomeTotal.ToString("c2");
            ExpenseTotalLabel.Text = budget.ExpenseTotal.ToString("c2");
            BalanceLabel.Text = budget.Balance.ToString("c2");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            double andreaIncome = 0;
            double jeremyIncome = 0;
            double rentIncome = 0;
            double rentExpense = 0;
            double mortgage = 0;

            if (!string.IsNullOrWhiteSpace(AndreasIncomeTextBox.Text))
            {
                double.TryParse(AndreasIncomeTextBox.Text, out andreaIncome);
            }

            if (!string.IsNullOrWhiteSpace(JeremysIncomeTextBox.Text))
            {
                double.TryParse(JeremysIncomeTextBox.Text, out jeremyIncome);
            }

            if (!string.IsNullOrWhiteSpace(RentIncomeTextBox.Text))
            {
                double.TryParse(RentIncomeTextBox.Text, out rentIncome);
            }

            if (!string.IsNullOrWhiteSpace(RentExpenseTextBox.Text))
            {
                double.TryParse(RentExpenseTextBox.Text, out rentExpense);
            }

            if (!string.IsNullOrWhiteSpace(MortgageTextBox.Text))
            {
                double.TryParse(MortgageTextBox.Text, out mortgage);
            }

            var incomeTotal = andreaIncome + jeremyIncome + rentIncome;
            var expenseTotal = rentExpense + mortgage;
            var balance = incomeTotal - expenseTotal;

            IncomeTotalLabel.Text = incomeTotal.ToString("c2");
            ExpenseTotalLabel.Text = expenseTotal.ToString("c2");
            BalanceLabel.Text = balance.ToString("c2");
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            Budget budget = new Budget
            {
                AndreasIncome = Convert.ToDouble(AndreasIncomeTextBox.Text),
                JeremysIncome = Convert.ToDouble(JeremysIncomeTextBox.Text),
                RentIncome = Convert.ToDouble(RentIncomeTextBox.Text),
                RentExpense = Convert.ToDouble(RentExpenseTextBox.Text),
                Mortage = Convert.ToDouble(MortgageTextBox.Text)
            };
        }
    }
}
