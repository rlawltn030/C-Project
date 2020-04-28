using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Hotel_Management_System
{
    class RESERVATION
    {
        CONNECT connection = new CONNECT();

        // 예약 추가
        public bool AddReservation(int roomNum, int clientId, string dateIn, string dateOut)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Insert into Reservations (roomNumber, clientId, DateIn, DateOut) values(" + roomNum + ", " + clientId + ", '" + dateIn + "', '" + dateOut + "')", connection.getConnection());

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

        public DataTable GetAllReserv()
        {
            SqlCommand sql = new SqlCommand("Select * from Reservations", connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return table;
        }

        // 예약 수정
        public bool EditReservation(int reservId, int roomNum, int clientId, string dateIn, string dateOut)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Update Reservations Set roomNumber = " + roomNum + ", clientId = " + clientId + ", DateIn = '" + dateIn + "', DateOut = '" + dateOut + "' Where reservId = " + reservId, connection.getConnection());

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

        // 예약 삭제
        public bool RemoveReservation(int reservId)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Delete From Reservations Where reservId = " + reservId, connection.getConnection());

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
