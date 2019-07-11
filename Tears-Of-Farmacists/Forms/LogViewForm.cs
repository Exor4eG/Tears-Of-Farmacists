using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Presenter.Common;
using Presenter.Views;

namespace Tears_Of_Farmacists.Forms
{
    public partial class LogViewForm : Form, ILogViewForm
    {
        public event Action CloseLog;
        public event Func<List<string[]>> GetData;
        public event Func<Result> GetResult;
        public LogViewForm(int font)
        {
            InitializeComponent();
            foreach (Control c in Controls)
                c.Font = new Font("Microsoft Sans Serif", font);
        }

        private void LogViewForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseLog();
        }

        private void LogViewForm_Shown(object sender, EventArgs e)
        {
            dataGridView1.RowHeadersVisible = false;
            Result res = GetResult();
            List<string[]> logView = GetData();
            L_T1.Text = string.Format("{0}%", Convert.ToDouble(res.r1) * 100);
            L_T2.Text = string.Format("{0}%", Convert.ToDouble(res.r2) * 100);
            L_T3.Text = string.Format("{0}%", Convert.ToDouble(res.r3) * 100);
            L_T4.Text = string.Format("{0}%", Convert.ToDouble(res.r4) * 100);
            foreach (var ans in logView)
                dataGridView1.Rows.Add(ans);
        }
    }
}
