using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 二猫图片伞
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Window = CloseLabel.BackColor;
            controlText = CloseLabel.ForeColor;

            
        }
        private static bool mov = false;//初始化
        private static int xpos;
        private static int ypos;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
        private static Color Window;
        private static Color controlText;
        private void CloseLabel_MouseEnter(object sender, EventArgs e)
        {
            CloseLabel.BackColor = Color.Red;
            CloseLabel.ForeColor = Window;
        }
        private void CloseLabel_MouseLeave(object sender, EventArgs e)
        {
            //Console.WriteLine("hello");
            CloseLabel.BackColor = Window;
            CloseLabel.ForeColor = controlText;
        }

        private void CloseLabel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            mov = true;

            xpos = MousePosition.X;//鼠标的x坐标为当前窗体左上角x坐标

            ypos = MousePosition.Y;//鼠标的y坐标为当前窗体左上角y坐标
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mov)

            {

                this.Left += MousePosition.X - xpos;//根据鼠标x坐标确定窗体的左边坐标x

                this.Top += MousePosition.Y - ypos;//根据鼠标的y坐标窗体的顶部，即Y坐标

                xpos = MousePosition.X;

                ypos = MousePosition.Y;

            }
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            

                mov = false;//停止移动

            

 
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            xpos = 0; //设置初始状态

            ypos = 0;

            mov = false;
        }
    }
}
