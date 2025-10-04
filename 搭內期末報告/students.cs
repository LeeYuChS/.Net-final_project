using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static 搭內期末報告.teacher;

namespace 搭內期末報告
{
    public partial class students : Form
    {
        public string Message { get; set; }//學生
        public string stud_num { get; set; }//學號

        public students()
        {
            InitializeComponent();
        }
        private void students_Load(object sender, EventArgs e)
        {

            
            label1.Text = "Welcome " + Message + "同學";
            label11.Text = Message;
            label10.Text = stud_num;
            //label18.Text =  File.ReadAllText("d:\\no.txt");// d:\\no.txt
            switch (stud_num)
            {
                case "1158029":
                    {
                        label22.Text = Global.matrix[0,0].ToString();//出席成績
                        label20.Text = Global.matrix[0, 1].ToString();//期中成績
                        label24.Text = Global.matrix[0, 2].ToString();//期末成績
                        label18.Text = Global.matrix[0, 3].ToString();//總成績
                        textBox1.Text = Global.teacher_comment[0];
                        break;
                    }
                case "1158044":
                    {
                        label22.Text = Global.matrix[1, 0].ToString();//出席成績
                        label20.Text = Global.matrix[1, 1].ToString();//期中成績
                        label24.Text = Global.matrix[1, 2].ToString();//期末成績
                        label18.Text = Global.matrix[1, 3].ToString();//總成績
                        textBox1.Text = Global.teacher_comment[1];
                        break;
                    }
                case "1158032":
                    {
                        label22.Text = Global.matrix[2, 0].ToString();//出席成績
                        label20.Text = Global.matrix[2, 1].ToString();//期中成績
                        label24.Text = Global.matrix[2, 2].ToString();//期末成績
                        label18.Text = Global.matrix[2, 3].ToString();//總成績
                        textBox1.Text = Global.teacher_comment[2];
                        break;
                    }
                case "1158014":
                    {
                        label22.Text = Global.matrix[3, 0].ToString();//出席成績
                        label20.Text = Global.matrix[3, 1].ToString();//期中成績
                        label24.Text = Global.matrix[3, 2].ToString();//期末成績
                        label18.Text = Global.matrix[3, 3].ToString();//總成績
                        textBox1.Text = Global.teacher_comment[3];
                        break;
                    }
                default:
                    {
                        MessageBox.Show("查無此人","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
            }
            double x =double.Parse(label18.Text);//判斷總成績及格與否
            if(x<60)
            {
                label18.ForeColor = Color.Red;
            }
            else
            {
                label18.ForeColor= Color.Green;
            }
            
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide(); // 隱藏 Form2
            home form1 = new home();//在home這個物件下創造form1，new home()指的是創造"home物件"
            form1.Show(); // 顯示 Form1
        }
    }
}
