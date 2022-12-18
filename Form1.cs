using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tambola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox3.Enabled=false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text))
                {
                    MessageBox.Show("Please enter the numbers");
                    textBox1.Text = textBox2.Text = "";
                }
                else
                {
                    random();
                    
                }
            }
            catch
            {
                MessageBox.Show("PLease enter an ' Intger number '");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = "";
        }

        private void random()
        {
            Random random = new Random();
            int FirstNumber =Math.Abs(int.Parse(textBox1.Text));
            int LastNumber = Math.Abs(int.Parse(textBox2.Text));

            if (FirstNumber < LastNumber)
            {
                int rand = random.Next(FirstNumber, LastNumber + 1);
                textBox3.TextAlign = HorizontalAlignment.Center;
                textBox3.Font = new Font(textBox3.Font.FontFamily, 70);
                textBox3.Text = rand.ToString();
            }
            else if (FirstNumber == LastNumber || FirstNumber > LastNumber)
            {
                textBox1.Text = textBox2.Text = textBox3.Text = "";
                MessageBox.Show("First number must be smaller than the second number");
            }
           
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }
    }
}
