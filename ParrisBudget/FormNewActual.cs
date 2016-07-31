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
    public partial class FormNewActual : Form
    {
        public FormNewActual()
        {
            InitializeComponent();
            Budget budget = Data.GetBudget();
            AndreasIncomeLabel.Text = budget.AndreasIncome.ToString("c2");
            JeremysIncomeLabel.Text = budget.JeremysIncome.ToString("c2");
            RentIncomeActualLabel.Text = budget.RentIncome.ToString("c2");
            RentExpenseLabel.Text = budget.RentExpense.ToString("c2");
            MortgageLabel.Text = budget.Mortage.ToString("c2");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
