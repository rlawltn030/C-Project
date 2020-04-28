using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management_System
{
    public partial class ManageRoomsForm : Form
    {
        ROOM room = new ROOM();

        public ManageRoomsForm()
        {
            InitializeComponent();
        }

        private void ManageRoomsForm_Load(object sender, EventArgs e)
        {
            // comboBox에 리스트를 불러옴
            comboBox_RoomType.DataSource = room.RoomTypeList();
            comboBox_RoomType.DisplayMember = "label";
            comboBox_RoomType.ValueMember = "category_id";

            // radioButton Yes로 초기화
            radioButton_Yes.Checked = true;

            // dataGridView 값 받아옴
            dataGridView1.DataSource = room.GetRooms();
        }

        private void button_AddRoom_Click(object sender, EventArgs e) // 객실 추가
        {
            try
            {
                int roomNum = Convert.ToInt32(textBox_RoomNum.Text);
                int type = Convert.ToInt32(comboBox_RoomType.SelectedValue.ToString());
                string email = textBox_Email.Text;
                string phone = textBox_Phone.Text;
                string free = "Yes";
                if (radioButton_Yes.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";
                }

                if (room.AddRoom(roomNum, type, email, phone, free))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("객실 추가 완료", "객실 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("객실 추가 실패", "객실 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ID 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_EditRoom_Click(object sender, EventArgs e) // 객실 수정
        {
            try
            {
                int roomNum = Convert.ToInt32(textBox_RoomNum.Text);
                int type = Convert.ToInt32(comboBox_RoomType.SelectedValue.ToString());
                string email = textBox_Email.Text;
                string phone = textBox_Phone.Text;
                string free = "Yes";
                if (radioButton_Yes.Checked)
                {
                    free = "Yes";
                }
                else
                {
                    free = "No";
                }

                if (room.EditRoom(roomNum, type, email, phone, free))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    MessageBox.Show("객실 수정 완료", "객실 수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("객실 수정 실패", "객실 수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ID 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveRoom_Click(object sender, EventArgs e) // 객실 삭제
        {
            try
            {
                int roomNum = Convert.ToInt32(textBox_RoomNum.Text);

                if (room.RemoveRoom(roomNum))
                {
                    dataGridView1.DataSource = room.GetRooms();
                    textBox_RoomNum.Text = null;
                    comboBox_RoomType.SelectedValue = 0;
                    textBox_Email.Text = null;
                    textBox_Phone.Text = null;
                    radioButton_Yes.Select();
                    MessageBox.Show("정보 삭제 완료", "객실 정보 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("정보 삭제 실패", "객실 정보 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "ID 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) 
        {
            textBox_RoomNum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBox_RoomType.SelectedValue = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_Email.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Phone.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("Yes"))
            {
                radioButton_Yes.Checked = true;
            }
            else
            {
                radioButton_No.Checked = true;
            }
            
        }

        private void comboBox_RoomType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
