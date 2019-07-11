using Presenter.Common;
using Presenter.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tears_Of_Farmacists.Forms
{
    public partial class TestForm : Form, ITestForm
    {
        private RequestResult requestResult;
        public event Func<Form, object> CloseTest;
        public event Func<int, RequestResult> GetNextQuestion;
        public event Func<int> Start;
        private Timer timer = new Timer();
        private TimeSpan time;
        private int font;
        private int qCount;
        private int count = 1;
        private Answer[] answersList;
        public TestForm(int font, int qCount)
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
            this.font = font;
            this.qCount = qCount;
            foreach (Control c in Controls)
            {
                c.Font = new Font("Microsoft Sans Serif", font);
            }
            answersList = new Answer[] { new Answer(TB_Answer1, RB_Var1), new Answer(TB_Answer2, RB_Var2), new Answer(TB_Answer3, RB_Var3), new Answer(TB_Answer4, RB_Var4) };
        }

        private void TestForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (time != TimeSpan.Zero)
            {
                DialogResult result = MessageBox.Show("Действительно прервать тест? Досрочное завершение теста проставит неверные ответы на непройденные вопросы.", "Тест не завершён", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    timer.Stop();
                    time = TimeSpan.Zero;
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TestForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseTest(new LogViewForm(font));
        }


        private void B_Confirm_Click(object sender, EventArgs e)
        {
            int answer = 0;
            if (answersList[0].rb.Checked)
                answer = 1;
            else if (answersList[1].rb.Checked)
                answer = 2;
            else if (answersList[2].rb.Checked)
                answer = 3;
            else if (answersList[3].rb.Checked)
                answer = 4;
            ShowTrue(answer);
            requestResult = GetNextQuestion(answer);
            count++;
            Delay(1500, (o, a) => RefreshView());
        }

        static void Delay(int ms, EventHandler action)
        {
            var tmp = new Timer { Interval = ms };
            tmp.Tick += new EventHandler((o, e) => tmp.Enabled = false);
            tmp.Tick += action;
            tmp.Enabled = true;
        }

        private void ShowTrue(int ans)
        {
            if (requestResult.IdTrueAnswer != ans - 1)
            {
                if (ans == 1)
                    answersList[0].tb.BackColor = Color.IndianRed;
                else if (ans == 2)
                    answersList[1].tb.BackColor = Color.IndianRed;
                else if (ans == 3)
                    answersList[2].tb.BackColor = Color.IndianRed;
                else if (ans == 4)
                    answersList[3].tb.BackColor = Color.IndianRed;
            }
            if (requestResult.IdTrueAnswer == 0)
                answersList[0].tb.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 1)
                answersList[1].tb.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 2)
                answersList[2].tb.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 3)
                answersList[3].tb.BackColor = Color.LightGreen;
        }

        private void RefreshView()
        {
            if (requestResult == null)
            {
                timer.Stop();
                time = TimeSpan.Zero;
                Close();
            }
            else
            {
                L_Q.Text = "Вопрос: "+ count + "/" + qCount;
                Mix();
                L_T.Text = "Тема: "+requestResult.Theme;
                TB_Question.Text = requestResult.Question;
                answersList[0].tb.Text = requestResult.Answer1;
                answersList[1].tb.Text = requestResult.Answer2;
                answersList[2].tb.Text = requestResult.Answer3;
                answersList[3].tb.Text = requestResult.Answer4;
                B_Confirm.Enabled = false;
                RB_Var1.Checked = RB_Var2.Checked = RB_Var3.Checked = RB_Var4.Checked = false;
                TB_Answer1.BackColor = Color.Empty;
                TB_Answer2.BackColor = Color.Empty;
                TB_Answer3.BackColor = Color.Empty;
                TB_Answer4.BackColor = Color.Empty;
            }
        }

        private void RB_Var1_Click(object sender, EventArgs e)
        {
            B_Confirm.Enabled = true;
        }

        private void RB_Var2_Click(object sender, EventArgs e)
        {
            B_Confirm.Enabled = true;
        }

        private void RB_Var3_Click(object sender, EventArgs e)
        {
            B_Confirm.Enabled = true;
        }

        private void RB_Var4_Click(object sender, EventArgs e)
        {
            B_Confirm.Enabled = true;
        }

        private void TestForm_Shown(object sender, EventArgs e)
        {
            requestResult = GetNextQuestion(0);
            time = new TimeSpan(0, 0, Start() + 1);
            timer.Interval = 1000;
            timer.Start();
            RefreshView();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            time -= TimeSpan.FromSeconds(1);

            L_Time.Text = string.Format("{0}:{1}", time.Minutes.ToString("00"), time.Seconds.ToString("00"));
            if (time == TimeSpan.Zero)
            {
                timer.Enabled = false;
                Close();
            }
        }
        private class Answer
        {
            public TextBox tb { get; }
            public RadioButton rb { get; }
            public Answer(TextBox tb, RadioButton rb)
            {
                this.tb = tb;
                this.rb = rb;
            }
        }
        private void Mix()
        {
            Random r = new Random();
            for (int i = answersList.Length - 1; i >= 1; i--)
            {
                int j = r.Next(i + 1);
                var temp = answersList[j];
                answersList[j] = answersList[i];
                answersList[i] = temp;
            }
        }
    }
}
