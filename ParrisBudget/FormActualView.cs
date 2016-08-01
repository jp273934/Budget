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
    public partial class FormActualView : Form
    {
        private Actual _actual;
        private Budget _budget;

        public FormActualView()
        {
            InitializeComponent();
        }

        public void LoadSelectedActual(Actual actual)
        {
            _actual = actual;
            _budget = Data.GetBudget();

            MonthLabel.Text = _actual.Month.ToString("MMMM yyyy");
            JeremysIncomeTextBox.Text = _actual.JeremyIncome.ToString();
            AndreasIncomeTextBox.Text = _actual.AndreaIncome.ToString();
            RentIncomeTextBox.Text = _actual.RentIncome.ToString();
            IncomeTotalLabel.Text = _actual.IncomeTotal.ToString("c2");

            LoadBillsBudget();

            LoadExpensesActual();
        }

        private void LoadExpensesActual()
        {
            RentExpenseTextBox.Text = _actual.RentExpense.ToString();
            MortgageTextBox.Text = _actual.Mortgage.ToString();
            ElectricityTextBox.Text = _actual.Electricity.ToString();
            CarInsuranceTextBox.Text = _actual.CarInsurance.ToString();
            DishTextBox.Text = _actual.DishBill.ToString();
            PhoneTextBox.Text = _actual.PhoneBill.ToString();
            WaterTextBox.Text = _actual.WaterBill.ToString();
            HealthInsuranceTextBox.Text = _actual.HealthInsurance.ToString();
            InternetTextBox.Text = _actual.Internet.ToString();
            GymTextBox.Text = _actual.Gym.ToString();
            DebtTextBox.Text = _actual.Debt.ToString();
        }

        private void LoadBillsBudget()
        {
            RentExpenseLabel.Text = _budget.RentExpense.ToString("c2");
            MortgageLabel.Text = _budget.Mortage.ToString("c2");
            ElectricityLabel.Text = _budget.Electricity.ToString("c2");
            CarInsuranceLabel.Text = _budget.CarInsurance.ToString("c2");
            DishLabel.Text = _budget.DishBill.ToString("c2");
            PhoneLabel.Text = _budget.PhoneBill.ToString("c2");
            WaterLabel.Text = _budget.WaterBill.ToString("c2");
            HealthInsuranceLabel.Text = _budget.HealthInsurance.ToString("c2");
            InternetLabel.Text = _budget.Internet.ToString("c2");
            GymLabel.Text = _budget.Gym.ToString("c2");
            DebtLabel.Text = _budget.Debt.ToString("c2");
        }

        private void UpdateIncomeButton_Click(object sender, EventArgs e)
        {
            var actual = new Actual
            {
                Id = _actual.Id,
                JeremyIncome = Convert.ToDouble(JeremysIncomeTextBox.Text),
                AndreaIncome = Convert.ToDouble(AndreasIncomeTextBox.Text),
                RentIncome = Convert.ToDouble(RentIncomeTextBox.Text)
            };

            Data.UpdateIncome(actual);

            LoadSelectedActual(Data.GetAllActual().FirstOrDefault(a => a.Id == _actual.Id));
        }
    }
}
