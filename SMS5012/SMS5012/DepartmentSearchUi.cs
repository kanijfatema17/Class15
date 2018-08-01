using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SMS5012.Models;

namespace SMS5012
{
    public partial class DepartmentSearchUi : Form
    {
        SqlConnection con = new SqlConnection(Common.ConnectionString());

        public DepartmentSearchUi()
        {
            InitializeComponent();
        }

        private void ShowAllButton_Click(object sender, EventArgs e)
        {

            int tockOutTypeId = (int)StockOutTypeEnum.Sales;

            string query = "SELECT * FROM Departments";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            departmentBindingSource.DataSource = dt;
            dataGridView1.DataSource = departmentBindingSource;
            con.Close();
            
        }

        private void DepartmentSearchUi_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Districts";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            districtBindingSource.DataSource = dt;
            con.Close();
        }

        private void districtComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            long id = Convert.ToInt64(districtComboBox.SelectedValue);

            string query = "SELECT * FROM SubDistricts WHERE DistrictId='" + id + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(dt);
            subDistrictBindingSource.DataSource = dt;
            con.Close();

        }
    }
}
