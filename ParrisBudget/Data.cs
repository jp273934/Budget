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
                        Mortage = Convert.ToDouble(reader["Mortgage"])
                    };
                    budget.Add(item);
                }

                connection.Close();              
            }
            return budget[0];
        }
    }
}
