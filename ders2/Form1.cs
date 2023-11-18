using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ders2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int mın_temprature = 0;
            const int max_temprature = 20;
            decimal f;
            listBox1.Items.Add("\tcelcius \t fahrenehit ");
            for (int i = mın_temprature; i <= max_temprature; i++)
            {
                f = (9m / 5) * i + 32;
                listBox1.Items.Add("\t" + i + "\t" + f);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            const int ıncrement = 5;
            const int mın_mınutes = 10;
            const int max_mınutes = 30;
            const decimal calorıes_burned_per_min = 3.9m;
            decimal result = 0.0m;

            listBox2.Items.Add("mınutes \t calories burned ");
            for (int i = mın_mınutes ; i < max_mınutes; i+= ıncrement)
            {
                result = i * calorıes_burned_per_min;
                listBox2.Items.Add(i + "\t" + result);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            const int startıng_tuıtıon = 6000;
            const int num_of_years = 5;
            const double ıncrease = 0.02;
            double new_tuition = startıng_tuıtıon;
            for (int i = 1; i < num_of_years; i++)
            {
                new_tuition += new_tuition * ıncrease;
                listBox3.Items.Add(i + "\t" + new_tuition).ToString("c");

            }
        }
        int first;
        int second;
        private void Form1_Load(object sender, EventArgs e)
        { /*olve renkli grup box için yazdık*/
            Random rnd = new Random();
            first = rnd.Next(100, 501);
            second = rnd.Next(100, 501);
            toplama.Text = first + "+" + second + "=?";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int answer;
            if (int.TryParse(textBox1.Text,out answer))
            {
                if (answer==first+second)
                {
                    mesaj.Text = "correct";
                }
                else
                {
                    mesaj.Text = "ıncorrect corren t answer is" + (first + second);
                }
            }
            else
            {
                    
            }
           
        }
    }
}
