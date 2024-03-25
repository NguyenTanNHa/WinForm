using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControl_đồng_hồ_đếm_ngược
{
    public partial class UCDongHoDemNguoc : UserControl
    {
        private int totalSeconds;

        public UCDongHoDemNguoc()
        {
            InitializeComponent();
        }

        private void UCDongHoDemNguoc_Load(object sender, EventArgs e)
        {


            for (int i = 0; i < 60; i++)
            {
                this.comboBox1.Items.Add(i.ToString());
                this.comboBox2.Items.Add(i.ToString());
                this.comboBox3.Items.Add(i.ToString());
            }
            this.comboBox1.SelectedIndex = 59;
            this.comboBox2.SelectedIndex = 59;
            this.comboBox3.SelectedIndex = 24;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = false;

            int minutes = int.Parse(this.comboBox1.SelectedItem.ToString());
            int seconds = int.Parse(this.comboBox2.SelectedItem.ToString());
            int hours = int.Parse(this.comboBox3.SelectedItem.ToString());

            totalSeconds = (hours * 3600) + (minutes * 60) + seconds;

            this.textBox1.ReadOnly = true;

            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int hours = totalSeconds / 3600;
                int remainingSeconds = totalSeconds % 3600;
                int minutes = remainingSeconds / 60;
                int seconds = remainingSeconds % 60;

                this.textBox1.Text = hours.ToString("D2") + ":" + minutes.ToString("D2") + ":" + seconds.ToString("D2");
            }
            else
            {
                this.textBox1.Text = "00:00:00";
                this.timer1.Enabled = false;
                MessageBox.Show("Thời Gian Đã Kết Thúc Rồi ! Vui Lòng Đặt Lại Thời Gian", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cho phép người dùng đặt lại thời gian và bắt đầu lại đếm ngược
                this.button1.Enabled = true;
            }

        }
    }
}
