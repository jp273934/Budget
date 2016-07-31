using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParrisBudget
{
    public static class Data
    {
        private static string BudgetConnection =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='C:\Users\Jeremy and Andrea\Documents\visual studio 2015\Projects\ParrisBudget\ParrisBudget\BudgetData.mdf';Integrated Security=True";
        public static Budget GetBudget()
        {
            List<Budget> budget = new List<Budget>();
            using (SqlConnection connection = new SqlConnection(BudgetConnection))
            {
                connection.Open();

                SqlCommand sqlCmd = new SqlCommand("SELECT * FROM Budget WHERE id = 1");
                sqlCmd.Connection = connection;
                SqlDataReader reader = sqlCmd.ExecuteReader();

                while (reader.Read())
                {
                    var item = new Budget
                    {
                        AndreasIncome = Convert.ToDouble(reader["AndreaIncome"]),
                        JeremysIncome = Convert.ToDouble(reader["JeremyIncome"]),
                        RentIncome = Convert.ToDouble(reader["RentIncome"]),
                        RentExpense = Convert.ToDouble(reader["RentExpense"]),
                        Mortage = Convert.ToDouble(reader["Mortgage"]),
                        Cigarettes = Convert.ToDouble(reader["Cigarettes"]),
                        Electricity = Convert.ToDouble(reader["Electricity"]),
                        CarInsurance = Convert.ToDouble(reader["CarInsurance"]),
                        DishBill = Convert.ToDouble(reader["DishBill"]),
                        PhoneBill = Convert.ToDouble(reader["PhoneBill"]),
                        WaterBill = Convert.ToDouble(reader["WaterBill"]),
                        GasCar = Convert.ToDouble(reader["GasCar"]),
                        GasTruck = Convert.ToDouble(reader["GasTruck"]),
                        HealthInsurance = Convert.ToDouble(reader["HealthInsurance"]),
                        Internet = Convert.ToDouble(reader["Internet"]),
                        Groceries = Convert.ToDouble(reader["Groceries"]),
                        Gym = Convert.ToDouble(reader["Gym"]),
                        Debt = Convert.ToDouble(reader["Debt"])
                    };
                    budget.Add(item);
                }

                connection.Close();              
            }
            return budget[0];
        }

        public static void SaveBudget(Budget _budget)
        {
            using (SqlConnection connection = new SqlConnection(BudgetConnection))
            using (SqlCommand command = connection.CreateCommand())
            {
                command.CommandText =
                    "UPDATE Budget SET AndreaIncome = @aIncome, JeremyIncome = @jIncome, RentIncome = @rIncome, RentExpense = @rExpense, Mortgage = @mortgage, Electricity = @electricity, CarInsurance = @cInsurance, DishBill = @dish, PhoneBill = @phone, WaterBill = @water, GasCar = @cGas, GasTruck = @gTruck, HealthInsurance = @hInsurance, Internet = @internet, Groceries = @groceries, Gym = @gym, Debt = @debt, Cigarettes = @cigs Where id = 1";

                command.Parameters.AddWithValue("@aIncome", _budget.AndreasIncome);
                command.Parameters.AddWithValue("@jIncome", _budget.JeremysIncome);
                command.Parameters.AddWithValue("@rIncome", _budget.RentIncome);
                command.Parameters.AddWithValue("@rExpense", _budget.RentExpense);
                command.Parameters.AddWithValue("@mortgage", _budget.Mortage);
                command.Parameters.AddWithValue("@electricity", _budget.Electricity);
                command.Parameters.AddWithValue("@cInsurance", _budget.CarInsurance);
                command.Parameters.AddWithValue("@dish", _budget.DishBill);
                command.Parameters.AddWithValue("@phone", _budget.PhoneBill);
                command.Parameters.AddWithValue("@water", _budget.WaterBill);
                command.Parameters.AddWithValue("@cGas", _budget.GasCar);
                command.Parameters.AddWithValue("@gTruck", _budget.GasTruck);
                command.Parameters.AddWithValue("@hInsurance", _budget.HealthInsurance);
                command.Parameters.AddWithValue("@internet", _budget.Internet);
                command.Parameters.AddWithValue("@groceries", _budget.Groceries);
                command.Parameters.AddWithValue("@gym", _budget.Gym);
                command.Parameters.AddWithValue("@debt", _budget.Debt);
                command.Parameters.AddWithValue("@cigs", _budget.Cigarettes);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
