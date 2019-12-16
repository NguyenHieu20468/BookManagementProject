using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BookDetail : Form
    {
        public int count = 0;
        private double rate = 0;
        public BookDetail()
        {
            InitializeComponent();            
            this.pictureBox1.Click += pictureBox1_Click;
            this.button2.Click += button2_Click;
            this.textBox1.Text = count.ToString(); 
        }

        void pictureBox1_Click(object sender, EventArgs e)
        {
            count++;
            this.textBox1.Text = count.ToString(); 
        }
   
        void button2_Click(object sender, EventArgs e)
        {
            var diem = double.Parse(this.textBox2.Text); // lấy số
            if (count == 1) // rate lần đầu = chính nó
            {
               this.textBox3.Text = diem.ToString();
               rate = diem; // lưu điểm rate lần 1 
            }
            else // rate lần N
            {
                var result = (((diem + rate) / count) + ((diem + rate) % count)); 
                rate =rate + result; // lấy rate cũ + rate mới 
                
                if (result > 10)
                {
                    this.textBox3.Text = "10";
                }
                else
                {
                    this.textBox3.Text = result.ToString();
                }              
            }           
        }       
    }
}
