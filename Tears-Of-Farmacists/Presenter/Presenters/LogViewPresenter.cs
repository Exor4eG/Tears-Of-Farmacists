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
    class LogViewPresenter : BasePresenter<ILogViewForm>
    {
        public event Action Close;
        private List<TestLog> log;
        private Result result;
        Data data;
        public LogViewPresenter(ILogViewForm view, Data d, List<TestLog> log, Result result) : base(view)
        {
            data = d;
            this.log = log;
            this.result = result;
            View.CloseLog += View_CloseLog;
            View.GetData += View_GetData;
            View.GetResult += View_GetResult;
        }

        private Result View_GetResult()
        {
            return result;
        }

        private List<string[]> View_GetData()
        {
            var res = new List<string[]>();
            foreach (var question in log)
            {
                if (question.idAnswer != question.idTrueAnswer && question.idAnswer != -1)
                {
                    res.Add(new string[]
                    {
                        data.testData.Subjects.ElementAt(question.IdTheme).Name,
                        data.testData.Subjects.ElementAt(question.IdTheme).Questions.ElementAt(question.idQuestion).Name,
                        data.testData.Subjects.ElementAt(question.IdTheme).Questions.ElementAt(question.idQuestion).Answers.ElementAt(question.idAnswer).Name,
                        data.testData.Subjects.ElementAt(question.IdTheme).Questions.ElementAt(question.idQuestion).Answers.ElementAt(question.idTrueAnswer).Name
                    });
                }
            }
            return res;
        }

        private void View_CloseLog()
        {
            Close();
        }
    }
}
