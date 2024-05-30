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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.ShowDialog();
            this.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Class1.CurrentGameMode = GameMode.WordsOnly;

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Class1.CurrentGameMode= GameMode.Sentencesonly;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            Class1.CurrentGameMode = GameMode.Both;
        }
    }
}
