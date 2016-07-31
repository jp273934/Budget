using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrisBudget
{
    public class Budget
    {
        public double AndreasIncome { get; set; }
        public double JeremysIncome { get; set; }
        public double RentIncome { get; set; }
        public double RentExpense { get; set; }
        public double Mortage { get; set; }
        public double ExpenseTotal => RentExpense + Mortage + Cigarettes + Electricity + CarInsurance + DishBill + PhoneBill + WaterBill + GasCar+ GasTruck + HealthInsurance + Internet + Groceries + Gym + Debt;
        public double IncomeTotal => AndreasIncome + JeremysIncome + RentIncome;
        public double Balance => IncomeTotal - ExpenseTotal;
        public double Cigarettes { get; set; }
        public double Electricity { get; set; }
        public double CarInsurance { get; set; }
        public double DishBill { get; set; }
        public double PhoneBill { get; set; }
        public double WaterBill { get; set; }
        public double GasCar { get; set; }
        public double GasTruck { get; set; }
        public double HealthInsurance { get; set; }
        public double Internet { get; set; }
        public double Groceries { get; set; }
        public double Gym { get; set; }
        public double Debt { get; set; }
    }
}
