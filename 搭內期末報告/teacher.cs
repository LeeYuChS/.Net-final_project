using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 搭內期末報告
{
    public partial class teacher : Form
    {  
        //宣告兩個全域陣列，讓3個form都能讀取
        public static class Global
        {
            public static double[,] matrix = new double[4, 4];

            public static string[] teacher_comment = new string[4];
        }
        public string Message { get; set; }
        //在teaacher中添加一個公共屬性或字段，用於接收來自Home的資料：

        public teacher()
        {
            InitializeComponent();
        }

        private void teacher_Load(object sender, EventArgs e)
        {
            label1.Text = "Welcome " + Message;
            //當teacher載入時，顯示歡迎對象
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //歸零與刷新數值
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            home form1 = new home();
            this.Hide(); // 隱藏 Form2
            form1.Show(); // 顯示 Form1
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                //教師將三種成績輸入
                double Attendance = double.Parse(textBox1.Text);
                double midterm = double.Parse(textBox2.Text);
                double Final = double.Parse(textBox3.Text);
                //求出加權後的總成績
                double Total = 0.3 * midterm + 0.4 * Final + 0.3 * Attendance;
                //取到小數點後第二位
                Total = Math.Round(Total, 2);
                textBox4.Text = Total.ToString();
                //判斷輸入的數值是否在合理範圍內，若超出範圍則顯示錯誤
                if (midterm > 100 || Final > 100 || Attendance > 100 || midterm < 0 || Final < 0 || Attendance < 0)
                {
                    MessageBox.Show("請在範圍內輸入成績", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox4.Text = "";
                }
                home form1 = new home();
                if (comboBox1.SelectedIndex == 0)//李宇晟
                {
                    //將成績存入陣列
                    Global.matrix[0, 0] = Attendance;
                    Global.matrix[0, 1] = midterm;
                    Global.matrix[0, 2] = Final;
                    Global.matrix[0, 3] = Total;
                    Global.teacher_comment[0] = textBox5.Text;
                }
                else if (comboBox1.SelectedIndex == 1)//葉建邑
                {
                    Global.matrix[1, 0] = Attendance;
                    Global.matrix[1, 1] = midterm;
                    Global.matrix[1, 2] = Final;
                    Global.matrix[1, 3] = Total;
                    Global.teacher_comment[1] = textBox5.Text;
                }
                else if (comboBox1.SelectedIndex == 2)//葉沛鑫
                {
                    Global.matrix[2, 0] = Attendance;
                    Global.matrix[2, 1] = midterm;
                    Global.matrix[2, 2] = Final;
                    Global.matrix[2, 3] = Total;
                    Global.teacher_comment[2] = textBox5.Text;
                }
                else if (comboBox1.SelectedIndex == 3)//鄭文婷
                {
                    Global.matrix[3, 0] = Attendance;
                    Global.matrix[3, 1] = midterm;
                    Global.matrix[3, 2] = Final;
                    Global.matrix[3, 3] = Total;
                    Global.teacher_comment[3] = textBox5.Text;
                }
            }
            catch(Exception ee) 
            {
                MessageBox.Show(ee.Message.ToString() + "請重新輸入","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                textBox1.Text = textBox2.Text = textBox3.Text = "";
            } 
        }
    }
}
