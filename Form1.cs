using System;
using System.Collections.Generic;
using System.Timers;
using System.Windows.Forms;

namespace Proektna_zadaca
{
    public partial class BrziPrsti : Form
    {
        DateTime endTime;
        string answer;
        Random random = new Random();
        List<string> listofEquations = new List<string>();
        List<string> Answers = new List<string>();

        public BrziPrsti()
        {
            InitializeComponent();
            #region AddEquations
            listofEquations.Add("3 * 9 + 7 * 4");
            listofEquations.Add("(2+52)/6");
            listofEquations.Add("236-185+(6/3+8)");
            listofEquations.Add("365+258+(12-8/2)");
            listofEquations.Add("63*4/5");
            listofEquations.Add("47+6/8+8");
            listofEquations.Add("3*7*8/3");
            listofEquations.Add("(45+36/2)*3");
            listofEquations.Add("7*(63/7+9-25)/2");
            listofEquations.Add("2*8*3*9");
            listofEquations.Add("(3+9)*8-(4+7)");
            listofEquations.Add("55-(6*4+89)-7");
            listofEquations.Add("36+73-567+8");
            listofEquations.Add("(2+(36+7)*8)-87");
            listofEquations.Add("6*4-7-3*2");
            listofEquations.Add("(((3+5)+(6*3))*2)");
            listofEquations.Add("3*2-(7+8*7)");
            listofEquations.Add("(5+6*8)-(7*4+8)");
            listofEquations.Add("2*75*(7-62)");
            listofEquations.Add("3*7-54+79");
            listofEquations.Add("32-78+152-96+36");
            listofEquations.Add("8*7+9+2-(7*8/2)");
            listofEquations.Add("32-74+85/2");
            listofEquations.Add("3+8-7-8*6-7");
            listofEquations.Add("((22+4)-(36+7)*2)");
            listofEquations.Add("8+64/2+74-9");
            listofEquations.Add("64-7+8*7/8");
            listofEquations.Add("32+9+7/2");
            listofEquations.Add("7*8+63-74+(5*4)");
            listofEquations.Add("22-(6+9/2)+(32+56/7)");
            #endregion

            #region AddAnswers
            Answers.Add("55");
            Answers.Add("9");
            Answers.Add("61");
            Answers.Add("631");
            Answers.Add("50.4");
            Answers.Add("55.75");
            Answers.Add("56");
            Answers.Add("189");
            Answers.Add("-24.5");
            Answers.Add("432");
            Answers.Add("85");
            Answers.Add("-65");
            Answers.Add("-450");
            Answers.Add("259");
            Answers.Add("11");
            Answers.Add("52");
            Answers.Add("-57");
            Answers.Add("17");
            Answers.Add("-8250");
            Answers.Add("46");
            Answers.Add("46");
            Answers.Add("39");
            Answers.Add("0.5");
            Answers.Add("+51");
            Answers.Add("-60");
            Answers.Add("105");
            Answers.Add("64");
            Answers.Add("44.5");
            Answers.Add("65");
            Answers.Add("54.5");
            #endregion
        }


        private void StartNewGame_Click(object sender, EventArgs e)
        {
            timer1.Start();
            endTime = DateTime.Now.AddMinutes(3);
            selectNewEquation();
            AnswerBox.Text = String.Empty;
            GoodAnswers.Text = "0";
            WrongAnswers.Text = "0";
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            if (currentTime > endTime)
            {
                timer1.Stop();
                MessageBox.Show("Крај на играта");
                return;
            }
            TimeSpan timedifference = endTime - currentTime;
            Timer.Text = timedifference.ToString("mm':'ss");

        }

        private void EnrollAnswerBotton_Click(object sender, EventArgs e)
        {
            if (AnswerBox.Text == answer)
            {
                int goodAnswers = int.Parse(GoodAnswers.Text);
                goodAnswers++;
                GoodAnswers.Text = goodAnswers.ToString();
            } else
            {
                 int wrongAnswers = int.Parse(WrongAnswers.Text);
                 wrongAnswers++;
                WrongAnswers.Text = wrongAnswers.ToString();
            }
            selectNewEquation();
            AnswerBox.Text = String.Empty;
        }

        public void selectNewEquation()
        {
            int randomIndex = random.Next(0, 29);
            ShowingEquation.Text = listofEquations[randomIndex];
            answer = Answers[randomIndex];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += "0";
        }

        private void buttonDot_Click(object sender, EventArgs e)
        {
            AnswerBox.Text += ".";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            string textAnswerBox = AnswerBox.Text;
            if (textAnswerBox.Length <= 1)
            {
                AnswerBox.Text = String.Empty;
            }
            else
            {
                AnswerBox.Text = textAnswerBox.Substring(0, textAnswerBox.Length - 1);
            }
        }
    }
}
