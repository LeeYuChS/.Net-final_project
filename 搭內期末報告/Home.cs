using Classlibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace 搭內期末報告
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        //老師、學生ID
        string Teacher1_ID = "0942180254";
        string Teacher2_ID = "0942091358";
        string lee_ID = "1812927013";
        string YA8_ID = "1809576981";
        string YA_ID = "1812504325";
        string Zheng_ID = "1812975477";
        /*1580274113
        1031906577
        1976822433
        0328531009
        4253484168*/

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        //這裡使用keydown事件，當使用者按下某個按鍵時觸發此事件
        {

            //keycode是一種屬性，當enter鍵按下去時，執行下列程式
            if (e.KeyCode == Keys.Enter)
            {
                string account = Convert.ToString(textBox1.Text);
                //讀取ID長度
                if (account.Length == 10)
                {
                    //切割ID字串
                    string identity = account.Substring(0, 2);
                    //學生身分"18"
                    if (identity == "18")
                    {
                        //新增畫面
                        students form2 = new students();
                        this.Visible = false;                                          //******1號visible******

                        //確認身分
                        if (lee_ID == account)
                        {
                            //form2.***的用法:***這些屬性被宣告在students、teacher(public)，然後藉由Home指定內容以達到傳遞資料的功能
                            form2.Message = "李宇晟";  //姓名傳遞

                            form2.stud_num = "1158029";//學號傳遞   
                        }
                        else if (YA8_ID == account)
                        {
                            form2.Message = "葉建邑";

                            form2.stud_num = "1158044";
                        }

                        else if (YA_ID == account)
                        {
                            form2.Message = "葉沛鑫";

                            form2.stud_num = "1158032";
                        }
                        else if (Zheng_ID == account)
                        {
                            form2.Message = "鄭文婷";

                            form2.stud_num = "1158014";
                        }
                        else
                        {
                            form2.Message = "尚未註冊";
                        }
                        //顯示畫面
                        form2.Show();
                    }
                    //老師身分"09"
                    else if (identity == "09")
                    {
                        teacher form3 = new teacher();
                        this.Visible = false;                   //******二號visible*****
                        if (Teacher1_ID == account)
                        {
                            form3.Message = "Apple老師";
                        }
                        else if (Teacher2_ID == account)
                        {
                            form3.Message = "炎清老師";
                        }
                        else
                        {
                            form3.Message = "尚未註冊";
                        }
                        form3.Show();
                    }
                    else
                    {

                        MessageBox.Show("卡片錯誤", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        textBox1.Text = "";

                        //以避免重複顯示錯誤訊息
                        return;
                    }

                }
                //手動輸入
                else if (account.Length > 0)
                {
                    MessageBox.Show("無此帳戶", "登入失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Text = "";
                    return;
                }
            }
        }
    }
}
