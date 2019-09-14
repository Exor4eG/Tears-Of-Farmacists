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
    public partial class MainForm : Form, IMainForm
    {
        List<string[]> result;
        int font;
        public MainForm()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
        }

        public event Func<string> GetInfo;
        public event Func<List<string[]>> GetResults;
        public event Func<string> GetTestTime;
        public event Func<string> GetQCount;
        public event Func<Form, object> StartTest;
        public event Func<int> GetFontSize;
        public event Action<int> SetFontSize;
        public event Action<Form> OpenTraining;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TB_Info.Text = GetInfo();
            result = GetResults();
            UpdateDGV();
            L_Time.Text = GetTestTime();
            L_QCount.Text = GetQCount();
            font = GetFontSize();
            ChangeFont();
        }

        private void UpdateDGV()
        {
            dataGridView1.Rows.Clear();
            foreach (var res in result)
            {
                dataGridView1.Rows.Add(res);
            }
            dataGridView1.Refresh();
        }

        private void B_StartTest_Click(object sender, EventArgs e)
        {
            SetFontSize(font);
            StartTest(new TestForm(font, Convert.ToInt32(GetQCount())));
            Hide();
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            result = GetResults();
            UpdateDGV();
        }

        private void B_FontU_Click(object sender, EventArgs e)
        {
            if (font < 14)
            {
                font++;
                ChangeFont();
            }
        }

        private void B_FontD_Click(object sender, EventArgs e)
        {
            if (font > 7)
            {
                font--;
                ChangeFont();
            }
        }
        private void ChangeFont()
        {
            foreach (Control c in this.Controls)
                    c.Font = new Font("Microsoft Sans Serif", font);
            B_FontU.Font = B_FontD.Font = new Font("Microsoft Sans Serif", 8);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SetFontSize(font);
        }

        private void B_Learn_Click(object sender, EventArgs e)
        {
            OpenTraining(new TrainingForm());
            Hide();
        }

    }
}
