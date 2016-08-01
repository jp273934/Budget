using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace ParrisBudget
{
    public class Actual
    {
        public int Id { get; set; }
        public DateTime Month { get; set; }
        public double AndreaIncome { get; set; }
        public double JeremyIncome { get; set; }
        public double RentIncome { get; set; }
        public double IncomeTotal => JeremyIncome + AndreaIncome + RentIncome;
        public double RentExpense { get; set; }
        public double Mortgage { get; set; }
        public List<double> Cigarettes { get; set; }
        public double Electricity { get; set; }
        public double CarInsurance { get; set; }
        public double DishBill { get; set; }
        public double PhoneBill { get; set; }
        public double WaterBill { get; set; }
        public List<double> GasCar { get; set; }
        public List<double> GasTruck { get; set; }
        public double HealthInsurance { get; set; }
        public double Internet { get; set; }
        public List<double> Groceries { get; set; }
        public double Gym { get; set; }
        public double Debt { get; set; }

        public double ExpenseTotal
            =>
                RentExpense + Mortgage + CigarettesTotal() + Electricity + CarInsurance + DishBill + PhoneBill + WaterBill +
                GasCarTotal() + GasTruckTotal() + HealthInsurance + Internet + GroceriesTotal() + Gym + Debt;

        public double Total => IncomeTotal - ExpenseTotal;
        public bool IsBudget { get; set; }

        private double CigarettesTotal()
        {
            return  Cigarettes?.Sum() ?? 0;
        }

        private double GasCarTotal()
        {
            return GasCar?.Sum() ?? 0;
        }

        private double GasTruckTotal()
        {
            return GasTruck?.Sum() ?? 0;
        }

        private double GroceriesTotal()
        {
            return Groceries?.Sum() ?? 0;
        }
    }
}
