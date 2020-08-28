using System;
using System.Windows.Forms;

namespace form_menu
{
    public partial class Lience : Form
    {
        int mov;
        int movX;
        int movY;
        public Lience()
        {
            InitializeComponent();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = 1;
            movX = e.X;
            movY = e.Y;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov == 1)
            {
                this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mov = 0;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ReadWriter rd = new ReadWriter();
            if (textBox1.Text == "admin" && textBox2.Text == "dien123123")
            {
                rd.SaveLienceKey();
                MessageBox.Show("MÁY TÍNH ĐÃ ĐƯỢC CẤP QUYỀN THÀNH CÔNG!!(=_+)");


            }
            else MessageBox.Show("THÔNG TIN TÀI KHOẢN HOẶC MẬT KHẨU KHÔNG CHÍNH XÁC");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

