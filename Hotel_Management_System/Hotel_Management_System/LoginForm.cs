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

namespace Hotel_Management_System
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button_Login_Click(object sender, EventArgs e)
        {
            CONNECT connection = new CONNECT();

            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select Count(*) from USERINFO where ID = '" + textBox_Username.Text + "' and PASSWORD = '" + textBox_Password.Text + "'", connection.getConnection());

            DataTable newTable = new DataTable();

            dataAdapter.Fill(newTable);

            if (newTable.Rows[0][0].ToString() =="1")
            {
                // 로그인 성공
                this.Hide();
                MainForm mainForm = new MainForm();

                mainForm.Show();
            }
            else
            {
                // 로그인 실패
                if (textBox_Username.Text.Trim().Equals(""))
                {
                    MessageBox.Show("아이디를 입력 하세요", "아이디 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (textBox_Password.Text.Trim().Equals(""))
                {
                    MessageBox.Show("비밀번호를 입력 하세요", "비밀번호 입력", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("가입하지 않은 아이디이거나, 잘못된 비밀번호입니다.", "로그인 실패", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}