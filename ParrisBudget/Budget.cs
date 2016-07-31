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
        public double ExpenseTotal => RentExpense + Mortage;
        public double IncomeTotal => AndreasIncome + JeremysIncome + RentIncome;
        public double Balance => IncomeTotal - ExpenseTotal;
    }
}
