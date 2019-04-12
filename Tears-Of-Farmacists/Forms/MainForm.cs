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
        public MainForm()
        {
            InitializeComponent();
        }

        public event Func<string> GetInfo;
        public event Func<List<string[]>> GetResults;
        public event Func<string> GetTestTime;
        public event Func<string> GetQCount;
        public event Action SetChooseOne;
        public event Action SetChooseTwo;

        private void MainForm_Shown(object sender, EventArgs e)
        {
            TB_Info.Text = GetInfo();
            result = GetResults();
            UpdateDGV();
            L_Time.Text = GetTestTime();
            L_QCount.Text = GetQCount();
        }

        private void UpdateDGV()
        {
            foreach (var res in result)
            {
                dataGridView1.Rows.Add(res);
            }
            dataGridView1.Refresh();
        }

        private void B_StartTest_Click(object sender, EventArgs e)
        {
            SetChooseOne();
            Close();
        }

        private void B_Intro_Click(object sender, EventArgs e)
        {
            SetChooseTwo();
            Close();
        }
    }
}
