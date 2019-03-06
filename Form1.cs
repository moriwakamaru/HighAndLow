using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace High_And_Low
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        long kazu = 0;
        int correctCount = 0;
        int notCorrectCount = 0;
        int continuingCorrectCount = 0;
        int maxContinuingCorrectCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Highボタンが押されたとき
            if (kazu >= 5)
            {
                label2.Text = "あたり";
                correctCount++;
                continuingCorrectCount++;
            }
            else
            {
                label2.Text = "はずれ";
                notCorrectCount++;
                continuingCorrectCount = 0;
            }
            label1.Text = kazu.ToString();

            if(maxContinuingCorrectCount<= continuingCorrectCount)
            {
                maxContinuingCorrectCount = continuingCorrectCount;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Lowボタンが押されたとき
            if (kazu <= 4)
            {
                label2.Text = "あたり";
                correctCount++;
                continuingCorrectCount++;
            }
            else
            {
                label2.Text = "はずれ";
                notCorrectCount++;
                continuingCorrectCount = 0;
            }
            label1.Text = kazu.ToString();

            if (maxContinuingCorrectCount <= continuingCorrectCount)
            {
                maxContinuingCorrectCount = continuingCorrectCount;
            }

            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            init();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            init();
        }

        private void init()
        {
            //起動時の初期処理
            label1.Text = "?";
            label2.Text = "5より大きいか小さいか";
            label3.Text = "正解回数は" + correctCount + "です。";
            label4.Text="不正解回数は"+ notCorrectCount + "です。";
            label5.Text = "連続正解回数は"+ continuingCorrectCount + "です。";
            label6.Text="最高連続正解回数は"+ maxContinuingCorrectCount + "です。";
            kazu = rand.Next(1, 10);
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
        }
    }
}
