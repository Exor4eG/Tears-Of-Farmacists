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
        public TestForm()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
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
            CloseTest(new LogViewForm());
        }


        private void B_Confirm_Click(object sender, EventArgs e)
        {
            int answer = 0;
            if (RB_Var1.Checked)
                answer = 1;
            else if (RB_Var2.Checked)
                answer = 2;
            else if (RB_Var3.Checked)
                answer = 3;
            else if (RB_Var4.Checked)
                answer = 4;
            ShowTrue(answer);
            requestResult = GetNextQuestion(answer);
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
                    TB_Answer1.BackColor = Color.IndianRed;
                else if (ans == 2)
                    TB_Answer2.BackColor = Color.IndianRed;
                else if (ans == 3)
                    TB_Answer3.BackColor = Color.IndianRed;
                else if (ans == 4)
                    TB_Answer4.BackColor = Color.IndianRed;
            }
            if (requestResult.IdTrueAnswer == 0)
                TB_Answer1.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 1)
                TB_Answer2.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 2)
                TB_Answer3.BackColor = Color.LightGreen;
            else if (requestResult.IdTrueAnswer == 3)
                TB_Answer4.BackColor = Color.LightGreen;
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
                L_Theme.Text = requestResult.Theme;
                TB_Question.Text = requestResult.Question;
                TB_Answer1.Text = requestResult.Answer1;
                TB_Answer2.Text = requestResult.Answer2;
                TB_Answer3.Text = requestResult.Answer3;
                TB_Answer4.Text = requestResult.Answer4;
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

    }
}
