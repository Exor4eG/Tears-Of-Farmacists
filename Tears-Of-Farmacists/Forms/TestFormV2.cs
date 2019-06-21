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
    public partial class TestFormV2 : Form, ITestForm
    {
        private RequestResult requestResult;
        public event Action CloseTest;
        public event Func<int, RequestResult> GetNextQuestion;
        public event Func<int> Start;
        private Timer timer = new Timer();
        private TimeSpan time;
        public TestFormV2()
        {
            InitializeComponent();
            timer.Tick += new EventHandler(timer_Tick);
        }

        private void TestFormV2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (time != TimeSpan.Zero)
            {
                DialogResult result = MessageBox.Show("Действительно прервать тест? Досрочное завершение теста проставит неверные ответы на непройденные вопросы.", "Тест не завершён", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    timer.Stop();
                    time = TimeSpan.Zero;
                    Close();
                }
                else if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TestFormV2_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseTest();
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
            requestResult = GetNextQuestion(answer);
            RefreshView();
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
                TB_Answer1.Text = requestResult.Answer2;
                TB_Answer1.Text = requestResult.Answer3;
                TB_Answer1.Text = requestResult.Answer4;
                B_Confirm.Enabled = false;
                RB_Var1.Checked = RB_Var2.Checked = RB_Var3.Checked = RB_Var4.Checked = false;
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

        private void RB_Var4_CheckedChanged(object sender, EventArgs e)
        {
            B_Confirm.Enabled = true;
        }

        private void TestFormV2_Shown(object sender, EventArgs e)
        {
            time = new TimeSpan(0, 0, Start() + 1);
            timer.Interval = 1000;
            timer.Start();
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
