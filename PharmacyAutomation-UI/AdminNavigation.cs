using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyAutomation_UI
{
    public partial class AdminNavigation : Form
    {
        public AdminNavigation()
        {
            InitializeComponent();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EmployeeCheck employeeCheck = new EmployeeCheck();
            employeeCheck.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMedicine addMedicine = new AddMedicine();
            addMedicine.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reports reports = new Reports();
            reports.ShowDialog();
        }

        private void AdminNavigation_Load(object sender, EventArgs e)
        {

        }

        private void AdminNavigation_FormClosed(object? sender, FormClosedEventArgs? e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
