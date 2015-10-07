using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using Business.Entities;

namespace Data.Database
{
    public class PlanAdapter : Adapter
    {
        public DataTable GetAll()
        {
            this.OpenConnection();
            DataTable dt = new DataTable();
            string query = "SELECT * FROM planes";
            MySqlCommand cmd = new MySqlCommand(query, SqlConn);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);
            adap.Fill(dt);
            this.CloseConnection();
            return dt;
        }

            
        public Plan GetOne(int id)
        {
        	throw new NotImplementedException();
        }
    }
}
