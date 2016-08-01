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
    public partial class FormMain : Form
    {
        private List<Actual> _actualData; 
        public FormMain()
        {
            InitializeComponent();
            LoadActualHistory();
        }

        public void LoadActualHistory()
        {
            _actualData = Data.GetAllActual();

            ActualsGridView.DataSource = _actualData;
        }

        private void newActualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewActual formNewActual = new FormNewActual();
            formNewActual.ShowDialog();
        }

        private void editBudgetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewBudget formNewBudget = new FormNewBudget();
            formNewBudget.ShowDialog();
        }

        private void ActualsGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView) sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                FormActualView actualView = new FormActualView();
                actualView.LoadSelectedActual(_actualData[e.RowIndex]);
                actualView.ShowDialog();
            }
        }
    }
}
