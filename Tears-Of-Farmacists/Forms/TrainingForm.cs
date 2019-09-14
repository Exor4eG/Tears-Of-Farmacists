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
    public partial class TrainingForm : Form, ITrainingForm
    {
        public event Action CloseTraining;
        public event Func<List<string[]>> GetData;
        public TrainingForm()
        {
            InitializeComponent();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.DefaultCellStyle.WrapMode =DataGridViewTriState.True;
        }

        private void TrainingForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseTraining();
        }

        private void TrainingForm_Shown(object sender, EventArgs e)
        {
            var data = GetData();
            foreach (var ans in data)
                dataGridView1.Rows.Add(ans);
        }
    }
}
