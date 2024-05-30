using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Israfil_Zekai_Yilmaz_68134_T8
{
    public partial class Form2 : Form
    {
        double Time = 10.0;
        int score = 0;
        string currentItem;

        public Form2()
        {
            InitializeComponent();
            Class1.LoadData();
            currentItem = Class1.Next();
            txtAnswer.Text = "";
            lblDisplay.Text = currentItem;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Time -= 0.1;
            lblTime.Text = Time.ToString("0.0");
            if (Time <= 0)
            {
                timer1.Stop();
                MessageBox.Show("Time's up! Your score:" + score);
                Form1 form1 = new Form1(); 
                this.Hide();
                form1.ShowDialog();
                this.Close();      
               
            }
        }

        private void txtAnswer_TextChanged(object sender, EventArgs e)
        {
            if (txtAnswer.Text.Equals(currentItem))
            {
                score++;
                lblPoint.Text = score.ToString();
                currentItem= Class1.Next();
                lblDisplay.Text = currentItem;
                txtAnswer.Text = "";
                Time = 10.0;

            }

        }
    }
}
