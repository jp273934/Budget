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

            LoadBudget();
        }

        private void LoadBudget()
        {
            Budget budget = Data.GetBudget();

            AndreasIncomeTextBox.Text = budget.AndreasIncome.ToString();
            JeremysIncomeTextBox.Text = budget.JeremysIncome.ToString();
            RentIncomeTextBox.Text = budget.RentIncome.ToString();
            RentExpenseTextBox.Text = budget.RentExpense.ToString();
            MortgageTextBox.Text = budget.Mortage.ToString();
            CigarettesTextBox.Text = budget.Cigarettes.ToString();
            ElectricityTextBox.Text = budget.Electricity.ToString();
            CarInsuranceTextBox.Text = budget.CarInsurance.ToString();
            DishBillTextBox.Text = budget.DishBill.ToString();
            PhoneBillTextBox.Text = budget.PhoneBill.ToString();
            WaterBillTextBox.Text = budget.WaterBill.ToString();
            CarGasTextBox.Text = budget.GasCar.ToString();
            TruckGasTextBox.Text = budget.GasTruck.ToString();
            HealthInsuranceTextBox.Text = budget.HealthInsurance.ToString();
            InternetTextBox.Text = budget.Internet.ToString();
            GroceriesTextBox.Text = budget.Groceries.ToString();
            GymTextBox.Text = budget.Gym.ToString();
            DebtTextBox.Text = budget.Debt.ToString();

            IncomeTotalLabel.Text = budget.IncomeTotal.ToString("c2");
            ExpenseTotalLabel.Text = budget.ExpenseTotal.ToString("c2");
            BalanceLabel.Text = budget.Balance.ToString("c2");
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double GetDollarAmount(TextBox box)
        {
            double amount = 0;

            if (!string.IsNullOrWhiteSpace(box.Text))
            {
                double.TryParse(box.Text, out amount);
            }

            return amount;
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {           
            double andreaIncome = GetDollarAmount(AndreasIncomeTextBox);
            double jeremyIncome = GetDollarAmount(JeremysIncomeTextBox);
            double rentIncome = GetDollarAmount(RentIncomeTextBox);
            double rentExpense = GetDollarAmount(RentExpenseTextBox);
            double mortgage = GetDollarAmount(MortgageTextBox);
            double cigarettes = GetDollarAmount(CigarettesTextBox);
            double electrictiy = GetDollarAmount(ElectricityTextBox);
            double carInsurance = GetDollarAmount(CarInsuranceTextBox);
            double dishBill = GetDollarAmount(DishBillTextBox);
            double phoneBill = GetDollarAmount(PhoneBillTextBox);
            double waterBill = GetDollarAmount(WaterBillTextBox);
            double carGas = GetDollarAmount(CarGasTextBox);
            double truckGas = GetDollarAmount(TruckGasTextBox);
            double healthInsurance = GetDollarAmount(HealthInsuranceTextBox);
            double internet = GetDollarAmount(InternetTextBox);
            double groceries = GetDollarAmount(GroceriesTextBox);
            double gym = GetDollarAmount(GymTextBox);
            double debt = GetDollarAmount(DebtTextBox);
          
            var incomeTotal = andreaIncome + jeremyIncome + rentIncome;
            var expenseTotal = rentExpense + mortgage + cigarettes + electrictiy + carInsurance + dishBill + phoneBill + waterBill + carGas + truckGas + healthInsurance + internet + groceries + gym + debt;
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
                Mortage = Convert.ToDouble(MortgageTextBox.Text),
                Cigarettes = Convert.ToDouble(CigarettesTextBox.Text),
                Electricity = Convert.ToDouble(ElectricityTextBox.Text),
                CarInsurance = Convert.ToDouble(CarInsuranceTextBox.Text),
                DishBill = Convert.ToDouble(DishBillTextBox.Text),
                PhoneBill = Convert.ToDouble(PhoneBillTextBox.Text),
                WaterBill = Convert.ToDouble(WaterBillTextBox.Text),
                GasCar = Convert.ToDouble(CarGasTextBox.Text),
                GasTruck = Convert.ToDouble(TruckGasTextBox.Text),
                HealthInsurance = Convert.ToDouble(HealthInsuranceTextBox.Text),
                Internet = Convert.ToDouble(InternetTextBox.Text),
                Groceries = Convert.ToDouble(GroceriesTextBox.Text),
                Gym = Convert.ToDouble(GymTextBox.Text),
                Debt = Convert.ToDouble(DebtTextBox.Text)
            };

            Data.SaveBudget(budget);

            LoadBudget();
        }
    }
}
