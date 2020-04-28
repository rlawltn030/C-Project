using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class CLIENT
    {
        CONNECT connection = new CONNECT();

        // CLIENTSINFO 테이블에 Insert
        public bool InsertClient(string firstName, string lastName, string email, string phone, string country)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Insert into CLIENTSINFO values('" + firstName + "', '" + lastName + "', '" + email + "', '" + phone + "', '" + country + "')", connection.getConnection());

            if(sql.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
            
        }

        // DataTable을 받아옴
        public DataTable GetClients()
        {
            SqlCommand sql = new SqlCommand("Select * from CLIENTSINFO", connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return table;
        }

        // Table 레코드 수정
        public bool EditClient(int id, string firstName, string lastName, string email, string phone, string country)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Update CLIENTSINFO Set firstname = '" + firstName + "', lastname = '" + lastName + "', email = '" + email + "', phone = '" + phone + "', country = '" + country + "' Where id = " + id, connection.getConnection());
            
            if (sql.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }

        // Table 레코드 삭제
        public bool RemoveClient(int id)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Delete From CLIENTSINFO Where id = " + id, connection.getConnection());

            if (sql.ExecuteNonQuery() == 1)
            {
                connection.closeConnection();
                return true;
            }
            else
            {
                connection.closeConnection();
                return false;
            }
        }
    }
}
