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
    public partial class StudentUi : Form
    {
        SqlConnection con = new SqlConnection(Common.ConnectionString());
        public StudentUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = new Student();
                student.Name = nameTextBox.Text;
                student.Address = addressRichTextBox.Text;

                bool isAdded = Add(student);
                if (isAdded)
                {
                    MessageBox.Show("Student Added");
                    return;
                }
                MessageBox.Show("Sorry!! Student Add Failed");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        public bool Add(Student student)
        {
            //1 Connection String
            // server; Database; Authentication

            //2 Connection

            

            //3 Query

            string query = @"INSERT INTO Students VALUES ('" + student.Name + "', '" + student.Address + "')";

            //4 SQL Command


            //5 Connection Open
            con.Open();

            //6 Execute


            //int affectedCount = command.ExecuteNonQuery();
            //if (affectedCount>0)
            //{

            //}
            SqlCommand command = new SqlCommand(query, con);

            bool isRowAffected = command.ExecuteNonQuery() > 0;


            //7 Connection Close
            con.Close();

            return isRowAffected;

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                long id = Convert.ToInt64(searchTextBox.Text);
                Student student = GetById(id);
                if (student != null)
                {
                    nameTextBox.Text = student.Name;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }


        public Student GetById(long id)
        {

            List<Student> students = new List<Student>();

            Student student = new Student();
            string query = "SELECT * FROM Students WHERE Id='" + id + "'";
            SqlCommand command = new SqlCommand(query, con);
            con.Open();
            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {

                student.Name = dr.GetValue(2).ToString();
                student.Name = dr["Name"].ToString();
            }
            con.Close();


            students.Add(student);
            return student;
        }

    }
}
