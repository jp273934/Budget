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
            MonthYearDatePicker.Format = DateTimePickerFormat.Custom;
            MonthYearDatePicker.CustomFormat = "MMMM yyyy";
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {            
            Data.CreateNewActual(MonthYearDatePicker.Value);
            FormMain mainForm = new FormMain();
            mainForm.LoadActualHistory();
        }
    }
}
