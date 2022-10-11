using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TGG_Logic;
using TGG_Model;
using MongoDB.Bson;

namespace TGG_UI
{
    public partial class Employees : Form
    {
        private EmployeeService employeeService;

        private Timer timer;

        public Employees()
        {
            try
            {
                InitializeComponent();

                employeeService = new EmployeeService();

                this.timer = new Timer();
                this.timer.Tick += EmployeesTickEvent;
                this.timer.Interval = 10000;
                this.timer.Start();

                LoadEmployeeGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to load employees!\nPlease contact the application administrator!", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TGGErrorLogger.WriteLogToFile(ex);
            }
            
        }

        private void LoadEmployeeGrid()
        {
            gridViewEmployees.DataSource = employeeService.GetAllEmployees();
            gridViewEmployees.Columns["MongoId"].Visible = false;
            gridViewEmployees.Columns["Password"].Visible = false;
            gridViewEmployees.Columns["EmployeeId"].HeaderText = "Employee ID";
            gridViewEmployees.Columns["EmployeeId"].Width = 110;
            gridViewEmployees.Columns["Email"].HeaderText = "Email address";
            gridViewEmployees.Columns["Email"].Width = 260;
            gridViewEmployees.Columns["FullName"].HeaderText = "Full name";
            gridViewEmployees.Columns["FullName"].Width = 260;
            gridViewEmployees.Columns["IsSDEmployee"].HeaderText = "SD Employee";
            gridViewEmployees.Columns["IsSDEmployee"].Width = 111;
            gridViewEmployees.ReadOnly = true;
            gridViewEmployees.RowHeadersVisible = false;
            gridViewEmployees.Columns.Cast<DataGridViewColumn>().ToList().ForEach(column => column.SortMode = DataGridViewColumnSortMode.NotSortable);
            gridViewEmployees.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
        }

        private void EmployeesTickEvent(object sender, EventArgs e)
        {
            try
            {
                LoadEmployeeGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to load employees!\nPlease contact the application administrator!", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TGGErrorLogger.WriteLogToFile(ex);
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                this.timer.Stop();
                AddEmployee addEmployeeForm = new AddEmployee(employeeService);
                addEmployeeForm.ShowDialog();
                LoadEmployeeGrid();
                this.timer.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something went wrong while trying to load employees!\nPlease contact the application administrator!", "Something went wrong...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TGGErrorLogger.WriteLogToFile(ex);
            }
        }
    }
}
