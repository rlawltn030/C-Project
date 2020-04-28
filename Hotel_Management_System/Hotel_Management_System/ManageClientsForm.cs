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
    public partial class ManageClientsForm : Form
    {
        CLIENT client = new CLIENT();

        public ManageClientsForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_AddClient_Click(object sender, EventArgs e) // 고객 추가
        {
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string email = textBox_Email.Text;
            string phone = textBox_Phone.Text;
            string country = textBox_Country.Text;

            if(firstName.Trim().Equals("") || lastName.Trim().Equals("") || email.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals("") )
            {
                MessageBox.Show("빈칸을 모두 입력하세요", "고객 등록", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool insertClient = client.InsertClient(firstName, lastName, email, phone, country);

                if (insertClient)
                {
                    dataGridView1.DataSource = client.GetClients();
                    MessageBox.Show("신규 고객 등록 완료", "고객 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("신규 고객 등록 실패", "고객 등록", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            
        }

        private void ManageClientsForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetClients(); // dataGridView에 고객 리스트 받아옴
        }

        private void button_EditClient_Click(object sender, EventArgs e) // 고객 정보 수정
        {
            int id;
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string email = textBox_Email.Text;
            string phone = textBox_Phone.Text;
            string country = textBox_Country.Text;

            try
            {
                id = Convert.ToInt32(textBox_ID.Text);

                if (firstName.Trim().Equals("") || lastName.Trim().Equals("") || email.Trim().Equals("") || phone.Trim().Equals("") || country.Trim().Equals(""))
                {
                    MessageBox.Show("빈칸을 모두 입력하세요", "고객 정보 수정", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    bool editClient = client.EditClient(id, firstName, lastName, email, phone, country);

                    if (editClient)
                    {
                        dataGridView1.DataSource = client.GetClients();
                        MessageBox.Show("정보 수정 완료", "고객 정보 수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("정보 수정 실패", "고객 정보 수정", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message,"ID 에러",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // 데이터 클릭시 각 빈칸에 내용이 입력됨
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox_ID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBox_FirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox_LastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox_Email.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox_Phone.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textBox_Country.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button_RemoveClient_Click(object sender, EventArgs e) // 고객 정보 삭제
        {
            try
            {
                int id = Convert.ToInt32(textBox_ID.Text);

                if (client.RemoveClient(id))
                {
                    dataGridView1.DataSource = client.GetClients();
                    textBox_ID.Text = null;
                    textBox_FirstName.Text = null;
                    textBox_LastName.Text = null;
                    textBox_Email.Text = null;
                    textBox_Phone.Text = null;
                    textBox_Country.Text = null;
                    MessageBox.Show("정보 삭제 완료", "고객 정보 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("정보 삭제 실패", "고객 정보 삭제", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message, "ID 에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
