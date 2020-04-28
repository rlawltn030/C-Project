namespace Hotel_Management_System
{
    partial class ManageReservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox_ReservID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker_OUT = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dateTimePicker_IN = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_RoomNumber = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_RoomType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_RemoveReserv = new System.Windows.Forms.Button();
            this.button_EditReserv = new System.Windows.Forms.Button();
            this.button_AddReserv = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_CilentID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.textBox_ReservID);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateTimePicker_OUT);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.dateTimePicker_IN);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBox_RoomNumber);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.comboBox_RoomType);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.button_RemoveReserv);
            this.panel2.Controls.Add(this.button_EditReserv);
            this.panel2.Controls.Add(this.button_AddReserv);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.textBox_CilentID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 2;
            // 
            // textBox_ReservID
            // 
            this.textBox_ReservID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_ReservID.Location = new System.Drawing.Point(132, 78);
            this.textBox_ReservID.Name = "textBox_ReservID";
            this.textBox_ReservID.ReadOnly = true;
            this.textBox_ReservID.Size = new System.Drawing.Size(131, 26);
            this.textBox_ReservID.TabIndex = 28;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(43, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Reserv ID:";
            // 
            // dateTimePicker_OUT
            // 
            this.dateTimePicker_OUT.CalendarFont = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_OUT.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_OUT.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_OUT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_OUT.Location = new System.Drawing.Point(132, 253);
            this.dateTimePicker_OUT.Name = "dateTimePicker_OUT";
            this.dateTimePicker_OUT.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker_OUT.TabIndex = 26;
            this.dateTimePicker_OUT.Value = new System.DateTime(2020, 4, 27, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(46, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Date Out:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // dateTimePicker_IN
            // 
            this.dateTimePicker_IN.CalendarFont = new System.Drawing.Font("굴림체", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_IN.CustomFormat = "yyyy/MM/dd";
            this.dateTimePicker_IN.Font = new System.Drawing.Font("굴림체", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker_IN.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_IN.Location = new System.Drawing.Point(132, 222);
            this.dateTimePicker_IN.Name = "dateTimePicker_IN";
            this.dateTimePicker_IN.Size = new System.Drawing.Size(169, 22);
            this.dateTimePicker_IN.TabIndex = 24;
            this.dateTimePicker_IN.Value = new System.DateTime(2020, 4, 27, 0, 0, 0, 0);
            this.dateTimePicker_IN.ValueChanged += new System.EventHandler(this.dateTimePicker_IN_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(59, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Date IN:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox_RoomNumber
            // 
            this.comboBox_RoomNumber.DropDownHeight = 194;
            this.comboBox_RoomNumber.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RoomNumber.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox_RoomNumber.FormattingEnabled = true;
            this.comboBox_RoomNumber.IntegralHeight = false;
            this.comboBox_RoomNumber.Location = new System.Drawing.Point(132, 185);
            this.comboBox_RoomNumber.Name = "comboBox_RoomNumber";
            this.comboBox_RoomNumber.Size = new System.Drawing.Size(131, 24);
            this.comboBox_RoomNumber.TabIndex = 22;
            this.comboBox_RoomNumber.SelectedIndexChanged += new System.EventHandler(this.comboBox_RoomNumber_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Room Number:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBox_RoomType
            // 
            this.comboBox_RoomType.DropDownHeight = 194;
            this.comboBox_RoomType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_RoomType.Font = new System.Drawing.Font("굴림", 12F);
            this.comboBox_RoomType.FormattingEnabled = true;
            this.comboBox_RoomType.IntegralHeight = false;
            this.comboBox_RoomType.Location = new System.Drawing.Point(132, 153);
            this.comboBox_RoomType.Name = "comboBox_RoomType";
            this.comboBox_RoomType.Size = new System.Drawing.Size(131, 24);
            this.comboBox_RoomType.TabIndex = 20;
            this.comboBox_RoomType.SelectedIndexChanged += new System.EventHandler(this.comboBox_RoomType_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(29, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Room Type:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // button_RemoveReserv
            // 
            this.button_RemoveReserv.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_RemoveReserv.Location = new System.Drawing.Point(211, 342);
            this.button_RemoveReserv.Name = "button_RemoveReserv";
            this.button_RemoveReserv.Size = new System.Drawing.Size(66, 34);
            this.button_RemoveReserv.TabIndex = 17;
            this.button_RemoveReserv.Text = "삭제";
            this.button_RemoveReserv.UseVisualStyleBackColor = true;
            this.button_RemoveReserv.Click += new System.EventHandler(this.button_RemoveReserv_Click);
            // 
            // button_EditReserv
            // 
            this.button_EditReserv.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_EditReserv.Location = new System.Drawing.Point(137, 342);
            this.button_EditReserv.Name = "button_EditReserv";
            this.button_EditReserv.Size = new System.Drawing.Size(68, 34);
            this.button_EditReserv.TabIndex = 16;
            this.button_EditReserv.Text = "수정";
            this.button_EditReserv.UseVisualStyleBackColor = true;
            this.button_EditReserv.Click += new System.EventHandler(this.button_EditReserv_Click);
            // 
            // button_AddReserv
            // 
            this.button_AddReserv.Font = new System.Drawing.Font("굴림", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button_AddReserv.Location = new System.Drawing.Point(50, 342);
            this.button_AddReserv.Name = "button_AddReserv";
            this.button_AddReserv.Size = new System.Drawing.Size(81, 34);
            this.button_AddReserv.TabIndex = 15;
            this.button_AddReserv.Text = "추가";
            this.button_AddReserv.UseVisualStyleBackColor = true;
            this.button_AddReserv.Click += new System.EventHandler(this.button_AddReserv_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(343, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(445, 369);
            this.dataGridView1.TabIndex = 14;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_CilentID
            // 
            this.textBox_CilentID.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox_CilentID.Location = new System.Drawing.Point(132, 112);
            this.textBox_CilentID.Name = "textBox_CilentID";
            this.textBox_CilentID.Size = new System.Drawing.Size(131, 26);
            this.textBox_CilentID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(52, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Client ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(800, 49);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("굴림체", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "예약 관리";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ManageReservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "ManageReservationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "예약 관리";
            this.Load += new System.EventHandler(this.ManageReservationForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_RemoveReserv;
        private System.Windows.Forms.Button button_EditReserv;
        private System.Windows.Forms.Button button_AddReserv;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_CilentID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_RoomType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_RoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateTimePicker_OUT;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker_IN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_ReservID;
        private System.Windows.Forms.Label label3;
    }
}