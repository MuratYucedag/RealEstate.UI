using RealEstate.BusinessLayer.Validation;
using RealEstate.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RealEstate.UI
{
    public partial class FrmEmployee : Form
    {
        public FrmEmployee()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            List<Employee> employees = BLEmployee.BLEmployeeList();
            dataGridView1.DataSource = employees;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Employee employee = new Employee();
            employee.EmployeeName = txtName.Text;
            employee.EmployeeSurname = txtSurname.Text;
            employee.EmployeeCity = txtCity.Text;
            BLEmployee.BLEmployeeInsert(employee);
        }

        private void btnList2_Click(object sender, EventArgs e)
        {
            List<Employee> employees = BLEmployee.BLEmployeeList2(txtName.Text, txtSurname.Text);
            dataGridView1.DataSource = employees;
        }
    }
}
