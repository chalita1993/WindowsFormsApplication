using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cmdCheck_Click(object sender, EventArgs e)
        {
            string str = ("รายการที่เลือก :" + Environment.NewLine);
            if (optMale.Checked == true)
            {
                str = str + "เพศ : ชาย" + Environment.NewLine;
            }
            else
            {
                str = str + "เพศ : หญิง" + Environment.NewLine;
            }

            str = str + ("อายุ :" + Environment.NewLine);
            if (opt1.Checked == true)
            {
                str = str + "น้อยกว่า 20 ปี" + Environment.NewLine;
            }
            if (opt2.Checked == true)
            {
                str = str + "20-40 ปี" + Environment.NewLine;
            }
            if (opt3.Checked == true)
            {
                str = str + "มากกว่า 40 ปี" + Environment.NewLine;
            }

            str = str + ("อายุรถของคุณ :" + Environment.NewLine);
            if (opt4.Checked == true)
            {
                str = str + "ต่ำกว่า 5 ปี" + Environment.NewLine;
            }
            if (opt5.Checked == true)
            {
                str = str + "5-10 ปี" + Environment.NewLine;
            }
            if (opt6.Checked == true)
            {
                str = str + "มากกว่า 10 ปี" + Environment.NewLine;
            }

            str = str + ("คุณตรวจสภาพรถของคุณบ่อยแค่ไหน :" + Environment.NewLine);
            if (opt7.Checked == true)
            {
                str = str + "บ่อยมาก" + Environment.NewLine;
            }
            if (opt8.Checked == true)
            {
                str = str + "บ่อย" + Environment.NewLine;
            }
            if (opt9.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            if (opt10.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            if (opt11.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }

            str = str + ("คุณตรวจสภาพรถของคุณก่อนออกเดินทางหรือไม่ :" + Environment.NewLine);
            if (opt12.Checked == true)
            {
                str = str + "ทุกครั้ง" + Environment.NewLine;
            }
            if (opt13.Checked == true)
            {
                str = str + "เป็นบางครั้ง" + Environment.NewLine;
            }
            if (opt14.Checked == true)
            {
                str = str + "นานๆครั้ง" + Environment.NewLine;
            }
            if (opt15.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }

            str = str + ("วิธีการตรวจสภาพรถของคุณ :" + Environment.NewLine);
            if (opt16.Checked == true)
            {
                str = str + "เข้าศูนย์" + Environment.NewLine;
            }
            if (opt17.Checked == true)
            {
                str = str + "เข้าอู่" + Environment.NewLine;
            }
            if (opt18.Checked == true)
            {
                str = str + "ตรวจด้วยตนเอง" + Environment.NewLine;
            }
            if (opt19.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }

            str = str + ("รถของคุณซ่อมบ่อยแค่ไหน :" + Environment.NewLine);
            if (opt20.Checked == true)
            {
                str = str + "บ่อยมาก" + Environment.NewLine;
            }
            if (opt21.Checked == true)
            {
                str = str + "บ่อย" + Environment.NewLine;
            }
            if (opt22.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            if (opt23.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            if (opt24.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }

            str = str + ("คุณใส่ใจกับการตรวจสภาพรถของคุณมากแค่ไหน :" + Environment.NewLine);
            if (opt25.Checked == true)
            {
                str = str + "มากที่สุด" + Environment.NewLine;
            }
            if (opt26.Checked == true)
            {
                str = str + "มาก" + Environment.NewLine;
            }
            if (opt27.Checked == true)
            {
                str = str + "พอสมควร" + Environment.NewLine;
            }
            if (opt28.Checked == true)
            {
                str = str + "น้อย" + Environment.NewLine;
            }
            if (opt29.Checked == true)
            {
                str = str + "ไม่เคยเลย" + Environment.NewLine;
            }


            MessageBox.Show(str, "ตรวจสอบ");
        }
    }
}
