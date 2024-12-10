using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_2
{
    public partial class Form1 : Form
    {
        private readonly Font defaultFont = new Font("Verdana", 16, FontStyle.Regular);
        private readonly Color defaultColor = Color.White;

        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.White;           
            
            GroupBox groupBox = new GroupBox
            {
                Text = "Nhóm Số Không",
                Font = new Font("Verdana", 28, FontStyle.Bold),
                ForeColor = defaultColor,
                Location = new Point(90, 80),
                Size = new Size(900, 450),
                BackColor = Color.FromArgb(133, 19, 33),
            };
           
            this.Controls.Add(groupBox);


            New_Label(groupBox, "STT", 100, 80, new Font("Verdana", 14, FontStyle.Bold));
            New_Label(groupBox, "Họ Và Tên", 300, 80, new Font("Verdana", 14, FontStyle.Bold));
            New_Label(groupBox, "MSSV", 700, 80, new Font("Verdana", 14, FontStyle.Bold));

            New_Label(groupBox, "1", 110, 130, defaultFont);
            New_Label(groupBox, "2", 110, 180, defaultFont);
            New_Label(groupBox, "3", 110, 230, defaultFont);
            New_Label(groupBox, "4", 110, 280, defaultFont);

            New_Label(groupBox, "Lê Viết Thành Thái", 250, 130, defaultFont);
            New_Label(groupBox, "Đinh Văn Quốc Tuấn", 250, 180, defaultFont);
            New_Label(groupBox, "Nguyễn Anh Phi", 250, 230, defaultFont);
            New_Label(groupBox, "Phan Huỳnh Minh Thịnh", 250, 280, defaultFont);

            New_Label(groupBox, "49.01.104.132", 650, 130, defaultFont);
            New_Label(groupBox, "49.01.104.165", 650, 180, defaultFont);
            New_Label(groupBox, "49.01.104.109", 650, 230, defaultFont);
            New_Label(groupBox, "49.01.104.145", 650, 280, defaultFont);


            Label label = new Label
            {
                Text = "Quản Lý Rạp Phim",
                Location = new Point(290, 370), 
                Font = new Font("Verdana", 24, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true
            };
            groupBox.Controls.Add(label);


            PictureBox pictureBox = new PictureBox
            {
                 Image = Properties.Resources.cinema5,               
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(180, 120),                     
                Location = new Point(750, 320),               
                BackColor = Color.Transparent
            };

            PictureBox pictureBox1 = new PictureBox
            {
                Image = Properties.Resources.cinema3,
         
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(180, 120),
                Location = new Point(15, 320),
                BackColor = Color.Transparent
            };
            PictureBox pictureBox2 = new PictureBox
            {
                 Image = Properties.Resources.cinema6,                

                SizeMode = PictureBoxSizeMode.Zoom,
                Size = new Size(150, 120),                     
                Location = new Point(770),               
                BackColor = Color.Transparent
            };

            groupBox.Controls.Add(pictureBox);
            groupBox.Controls.Add(pictureBox1);
            groupBox.Controls.Add(pictureBox2);
        }

      
        private void New_Label(GroupBox parent, string text, int x, int y, Font font)
        {
            Label lbl = new Label
            {
                Text = text,
                Font = font,
                ForeColor = defaultColor,
                AutoSize = true,
                Location = new Point(x, y),
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            parent.Controls.Add(lbl);
        }
      

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            int startX = -this.Width; 
            int endX = (Screen.PrimaryScreen.WorkingArea.Width - this.Width) / 2;
            int currentX = startX;

            while (currentX < endX)
            {
                this.Location = new Point(currentX, this.Location.Y); 
                currentX += 30; 
                Thread.Sleep(6); 
            }

            this.Location = new Point(endX, this.Location.Y); 
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

