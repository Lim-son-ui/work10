using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)      //判斷輸入為奇數或偶數
        {
            int a = Convert.ToInt32(txt_in.Text);
            //MessageBox.Show(a.ToString());
            if ((a % 2) == 0)
            {
                txt_out.Text = "輸入為偶數";
            }
            else
            {
                txt_out.Text = "輸入為奇數";
            }
            //txt_out.Text = txt_in.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)          //判斷陣列內最大最小值
        {
            int[] arr0711 = { 1,5,6,8,7,97,54,887,65,578};

            int  max=0 , i , min=1000;
            for(i = 0; i < arr0711.Length; i++)
            {
                if (arr0711[i] > max)
                {
                    max = arr0711[i];
                }
                if (arr0711[i] < min)
                {
                    min = arr0711[i];
                }
            }
            txt_out.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                +"\r\n最大值為:" + max.ToString() 
                + "\r\n最小值為:" + min.ToString();

        }

        private void button3_Click(object sender, EventArgs e)      //判斷奇偶數 數量
        {
            int[] arr0711 = new int[] { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
            int sum1 = 0, sum2 = 0;

            for(int i = 0;i < arr0711.Length;i++)
            {
                if(arr0711[i] % 2 == 1)
                {
                    sum1++;
                }

                else
                {
                    sum2++;
                }
            }

            label1.Text = "int陣列arr0711[1,5,6,8,7,97,54,887,65,578]"
                + "\r\n奇數共:" + sum1.ToString()
                + "\r\n偶數共:" + sum2.ToString();
        }

        private void button4_Click(object sender, EventArgs e)  //統計名字的長度
        {
            string[] arr0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int flag = 0, max = 0;


            for(int i = 0; i < arr0711_str.Length ; i++)
            {
                if (flag == 0)
                {
                    max = arr0711_str[0].Length;
                    flag++;
                }

                else
                {
                    if(max < arr0711_str[i].Length)
                    {
                        max = i;
                    }
                    label1.Text = "陣列arr0711[]str[ 迪克蕭 J40 Candy Cindy  Coconut Motherfacker]"
                                    + "\r\n最長的名字:" + arr0711_str[max];
                }


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] arr0711_str = new string[] { "mother張", "emma", "迪克蕭", "J40", "Candy", "Cindy", "Coconut", "Motherfacker" };
            int count = 0 ;


            for (int i = 0; i < arr0711_str.Length; i++)
            {
                for(int j = 0 ; j <  arr0711_str[i].Length ; j++)
                {
                    
                    if(j == (arr0711_str[i].Length - 1))
                    {
                        if(string.Compare(arr0711_str[i].Substring(j), "C") == 0 || string.Compare(arr0711_str[i].Substring(j), "c"){
                            count++;
                            break;
                        }
                    }
                    else if (string.Compare(arr0711_str[i].Substring(j,j+1), "C") == 0 || string.Compare(arr0711_str[i].Substring(j,j+1), "c") == 0)
                    {
                        count++;
                        break;
                    }


                }
                
     
            }


            label1.Text = "陣列arr0711[]str[ 迪克蕭 J40 Candy Cindy  Coconut Motherfacker]"
                                    + "\r\n有C及C的名字共:" + count + "個";
        }
    }
}
