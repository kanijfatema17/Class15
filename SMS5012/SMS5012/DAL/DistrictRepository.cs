using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SMS5012.Models;

namespace SMS5012.DAL
{
    public class DistrictRepository
    {
        SqlConnection _con = new SqlConnection(Common.ConnectionString());

        public bool Add(District district)
        {
            // Db Ralated And Validation(If Needed) Goes Here
            // After Completed/ Checking

            string query = @"INSERT INTO Districts VALUES ('" + district.Name + "')";
            _con.Open();
            SqlCommand command = new SqlCommand(query, _con);
            bool isRowAffected = command.ExecuteNonQuery() > 0;

            _con.Close();

            return isRowAffected;
        }


    }
}
