using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using TomsTools2.ClassLibs;
using System.Data;

namespace TomsTools2.ClassLibs
{
     public class Door
    {
        public int _doorID { get; set; }


        public Door(int doorID)
        {
            _doorID = doorID;
            
        }

        public void GetDoorData()
        {
            SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("Select * from dbo.door where id = @doorID", conn);
            cmd.Parameters.AddWithValue("@doorID", _doorID);

            SqlDataReader rdr = cmd.ExecuteReader();

            if (rdr.Read())
            {

            }

            conn.Close();

        }

        public void updatePunch()
        {
            SqlConnection conn = new SqlConnection(ConnectionStrings.ConnectionString);
            conn.Open();

            SqlCommand cmd = new SqlCommand("update_stuck_punch_jobs", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@doorID", SqlDbType.Int).Value = _doorID;

            cmd.ExecuteNonQuery();
        }

    }
}
