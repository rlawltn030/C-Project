using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Management_System
{
    class ROOM
    {
        CONNECT connection = new CONNECT();

        public DataTable RoomTypeList()
        {
            SqlCommand sql = new SqlCommand("Select * from Rooms_Category", connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return table;
        }

        public DataTable RoomByType(int type)
        {
            SqlCommand sql = new SqlCommand("Select * from Rooms Where roomType =" + type + "and free = 'Yes'", connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return table;
        }

        public int GetRoomType(int number)
        {
            SqlCommand sql = new SqlCommand("Select roomType from Rooms Where roomNumber =" + number, connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return Convert.ToInt32(table.Rows[0][0].ToString());
        }

        // 예약 추가시 free 업데이트
        public bool SetRoomFree(int number, string free)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("UPDATE Rooms SET free = '" + free + "' Where roomNumber = " + number, connection.getConnection());

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

        // 객실 추가
        public bool AddRoom(int roomNum, int type, string email, string phone, string free)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Insert into Rooms values(" + roomNum + ", " + type + ", '" + email + "', '" + phone + "', '" + free + "')", connection.getConnection());

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

        // 객실 정보
        public DataTable GetRooms()
        {
            SqlCommand sql = new SqlCommand("Select * from Rooms", connection.getConnection());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = sql;
            adapter.Fill(table);

            return table;
        }

        // 객실 수정
        public bool EditRoom(int roomNum, int type, string email, string phone, string free)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Update Rooms Set roomNumber = " + roomNum + ", roomType = " + type + ", email = '" + email + "', phone = '" + phone + "', free = '" + free + "' Where roomNumber = " + roomNum, connection.getConnection());

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

        // 객실 삭제
        public bool RemoveRoom(int roomNum)
        {
            connection.openConnection();

            SqlCommand sql = new SqlCommand("Delete From Rooms Where roomNumber = " + roomNum, connection.getConnection());

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
