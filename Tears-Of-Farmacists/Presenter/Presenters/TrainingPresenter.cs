using Model;
using Presenter.Common;
using Presenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    class TrainingPresenter : BasePresenter<ITrainingForm>
    {
        public event Action Close;
        private Data data;
        public TrainingPresenter(ITrainingForm view, Data d) : base(view)
        {
            data = d;
            View.CloseTraining += View_CloseTraining;
            View.GetData += View_GetData; ;
        }

        private List<string[]> View_GetData()
        {
            var dataTraining = new List<string[]>();
            foreach(Subject a in data.testData.Subjects)
            {
                string[] question = new string[3];
                question[0] = a.Name;
                foreach(Question b in a.Questions)
                {
                    string[] que = new string[3];
                    que = question;
                    que[1] = b.Name;
                    foreach(Answer c in b.Answers)
                    {
                        if (c.IsTrue == true)
                        {
;                            dataTraining.Add(new string[] {que[0], que[1], c.Name });
                            break;
                        }
                    }
                }
            }
            return dataTraining;
        }

        private void View_CloseTraining()
        {
            Close();
        }

    }
}
