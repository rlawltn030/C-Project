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
    public partial class ManageReservationForm : Form
    {
        ROOM room = new ROOM();
        RESERVATION reservation = new RESERVATION();

        public ManageReservationForm()
        {
            InitializeComponent();
        }

        private void button_AddReserv_Click(object sender, EventArgs e) // 예약 등록
        {
            try
            {
                int clientID = Convert.ToInt32(textBox_CilentID.Text);
                int roomNumber = Convert.ToInt32(comboBox_RoomNumber.SelectedValue);
                string dateIn = dateTimePicker_IN.Value.ToShortDateString();
                string dateOut = dateTimePicker_OUT.Value.ToShortDateString();

                // date in > today date
                if(dateTimePicker_IN.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("잘못된 날짜 선택 입니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(dateTimePicker_OUT.Value < dateTimePicker_IN.Value)
                {
                    MessageBox.Show("잘못된 날짜 선택 입니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.AddReservation(roomNumber, clientID, dateIn, dateOut))
                    {
                        room.SetRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.GetAllReserv();
                        MessageBox.Show("예약 추가 완료", "예약 추가", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("예약 추가 실패", "예약 추가", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "예약 추가 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button_EditReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservID = Convert.ToInt32(textBox_ReservID.Text);
                int clientID = Convert.ToInt32(textBox_CilentID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());
                string dateIn = dateTimePicker_IN.Value.ToShortDateString();
                string dateOut = dateTimePicker_OUT.Value.ToShortDateString();

                // date in > today date
                if (dateTimePicker_IN.Value < DateTime.Now.Date)
                {
                    MessageBox.Show("잘못된 날짜 선택 입니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (dateTimePicker_OUT.Value < dateTimePicker_IN.Value)
                {
                    MessageBox.Show("잘못된 날짜 선택 입니다.", "날짜 선택 오류", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (reservation.EditReservation(reservID ,roomNumber, clientID, dateIn, dateOut))
                    {
                        room.SetRoomFree(roomNumber, "No");
                        dataGridView1.DataSource = reservation.GetAllReserv();
                        MessageBox.Show("예약 수정 완료", "예약 수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("예약 수정 실패", "예약 수정", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "예약 추가 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_RemoveReserv_Click(object sender, EventArgs e)
        {
            try
            {
                int reservId = Convert.ToInt32(textBox_ReservID.Text);
                int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString());

                if (reservation.RemoveReservation(reservId))
                {
                    room.SetRoomFree(roomNumber, "Yes");
                    dataGridView1.DataSource = reservation.GetAllReserv();
                    MessageBox.Show("예약 삭제 완료", "예약 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("예약 삭제 실패", "예약 삭제", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                reservation.RemoveReservation(reservId);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "예약 삭제 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ManageReservationForm_Load(object sender, EventArgs e)
        {
            dateTimePicker_IN.Value = DateTime.Now;
            dateTimePicker_OUT.Value = DateTime.Now;

            // comboBox에 리스트를 받아옴
            comboBox_RoomType.DataSource = room.RoomTypeList();
            comboBox_RoomType.DisplayMember = "label";
            comboBox_RoomType.ValueMember = "category_id";

            int type = Convert.ToInt32(comboBox_RoomType.SelectedValue.ToString());
            comboBox_RoomNumber.DataSource = room.RoomByType(type);
            comboBox_RoomNumber.DisplayMember = "roomNumber";
            comboBox_RoomNumber.ValueMember = "roomNumber";

            // list 표시
            dataGridView1.DataSource = reservation.GetAllReserv();
        }

        private void comboBox_RoomType_SelectedIndexChanged(object sender, EventArgs e) // comboBox_RoomNumber에 RoomType에 해당하는 값만 들어감
        {
            try
            {
                int type = Convert.ToInt32(comboBox_RoomType.SelectedValue.ToString());
                comboBox_RoomNumber.DataSource = room.RoomByType(type);
                comboBox_RoomNumber.DisplayMember = "roomNumber";
                comboBox_RoomNumber.ValueMember = "roomNumber";
            }
            catch (Exception exception)
            {
                //MessageBox.Show(exception.Message, "ID 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker_IN_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e) // dataGireView의 row 선택시 각 입력칸에 값이 들어감.
        {
            textBox_ReservID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_CilentID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

            int roomNumber = Convert.ToInt32(dataGridView1.CurrentRow.Cells[1].Value.ToString()); // List의 roomNumber를 받아온다.
            comboBox_RoomType.SelectedValue = room.GetRoomType(roomNumber); // roomNumber를 통해 해당 RoomType을 받아 comboBox에 넣는다.

            comboBox_RoomNumber.SelectedValue = roomNumber;

            dateTimePicker_IN.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            dateTimePicker_OUT.Value = DateTime.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
            
        }

        private void comboBox_RoomNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
