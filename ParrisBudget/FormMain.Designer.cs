namespace ParrisBudget
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ActualsGridView = new System.Windows.Forms.DataGridView();
            this.actualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.editBudgetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newActualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expenseTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.View = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ActualsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActualsGridView
            // 
            this.ActualsGridView.AutoGenerateColumns = false;
            this.ActualsGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ActualsGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.ActualsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ActualsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.monthDataGridViewTextBoxColumn,
            this.incomeTotalDataGridViewTextBoxColumn,
            this.expenseTotalDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.View});
            this.ActualsGridView.DataSource = this.actualBindingSource;
            this.ActualsGridView.Location = new System.Drawing.Point(29, 41);
            this.ActualsGridView.Name = "ActualsGridView";
            this.ActualsGridView.Size = new System.Drawing.Size(710, 150);
            this.ActualsGridView.TabIndex = 0;
            this.ActualsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ActualsGridView_CellContentClick);
            // 
            // actualBindingSource
            // 
            this.actualBindingSource.DataSource = typeof(ParrisBudget.Actual);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editBudgetToolStripMenuItem,
            this.newActualToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(763, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // editBudgetToolStripMenuItem
            // 
            this.editBudgetToolStripMenuItem.Name = "editBudgetToolStripMenuItem";
            this.editBudgetToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.editBudgetToolStripMenuItem.Text = "Edit Budget";
            this.editBudgetToolStripMenuItem.Click += new System.EventHandler(this.editBudgetToolStripMenuItem_Click);
            // 
            // newActualToolStripMenuItem
            // 
            this.newActualToolStripMenuItem.Name = "newActualToolStripMenuItem";
            this.newActualToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.newActualToolStripMenuItem.Text = "New Actual";
            this.newActualToolStripMenuItem.Click += new System.EventHandler(this.newActualToolStripMenuItem_Click);
            // 
            // monthDataGridViewTextBoxColumn
            // 
            this.monthDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.monthDataGridViewTextBoxColumn.DataPropertyName = "Month";
            this.monthDataGridViewTextBoxColumn.HeaderText = "Month";
            this.monthDataGridViewTextBoxColumn.Name = "monthDataGridViewTextBoxColumn";
            this.monthDataGridViewTextBoxColumn.Width = 62;
            // 
            // incomeTotalDataGridViewTextBoxColumn
            // 
            this.incomeTotalDataGridViewTextBoxColumn.DataPropertyName = "IncomeTotal";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.incomeTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.incomeTotalDataGridViewTextBoxColumn.HeaderText = "IncomeTotal";
            this.incomeTotalDataGridViewTextBoxColumn.Name = "incomeTotalDataGridViewTextBoxColumn";
            this.incomeTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // expenseTotalDataGridViewTextBoxColumn
            // 
            this.expenseTotalDataGridViewTextBoxColumn.DataPropertyName = "ExpenseTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.expenseTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.expenseTotalDataGridViewTextBoxColumn.HeaderText = "ExpenseTotal";
            this.expenseTotalDataGridViewTextBoxColumn.Name = "expenseTotalDataGridViewTextBoxColumn";
            this.expenseTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // View
            // 
            this.View.HeaderText = "";
            this.View.Name = "View";
            this.View.Text = "View";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 261);
            this.Controls.Add(this.ActualsGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Parris Budget";
            ((System.ComponentModel.ISupportInitialize)(this.ActualsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.actualBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ActualsGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editBudgetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newActualToolStripMenuItem;
        private System.Windows.Forms.BindingSource actualBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn monthDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expenseTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn View;
    }
}

