using Model;
using Presenter.Common;
using Presenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Presenters
{
    class TestPresenter : BasePresenter<ITestForm>
    {
        private Data data;
        public event Func<List<TestLog>, Form, Result, object> Close;
        private Result result = new Result();
        private List<TestLog> log = new List<TestLog>();
        private int QuestionIndex = -1;
        public TestPresenter(ITestForm view, Data d) : base(view)
        {
            data = d;
            View.CloseTest += View_CloseTest;
            View.GetNextQuestion += View_GetNextQuestion;
            View.Start += View_Start;
            PrepareTest();
        }
        private void PrepareTest()
        {
            for (int i = 0; i < 4; i++)
            {
                int countQTotal = data.testData.Subjects.ElementAt(i).Questions.Count;
                int countQ = data.testData.Subjects.ElementAt(i).QCount;
                Random random = new Random();
                int[] indQ = new int[countQ];
                for (int o = 0; o < countQ; o++)
                    indQ[o] = -1;
                for (int j = 0; j < countQ; j++)
                {
                    int ind = random.Next(0, countQTotal);
                    if (indQ.Contains(ind))
                        j--;
                    else
                        indQ[j] = ind;
                }
                foreach (var ind in indQ)
                {
                    int indA = -1;
                    for (int ans = 0; ans < 4; ans++)
                    {
                        if (data.testData.Subjects.ElementAt(i).Questions.ElementAt(ind).Answers.ElementAt(ans).IsTrue == true)
                        {
                            indA = ans;
                            break;
                        }
                    }
                    log.Add(new TestLog(i, ind, indA, -1));
                }
            }
        }

        private int View_Start()
        {
            return data.testData.Setting.Time;
        }

        private RequestResult View_GetNextQuestion(int answer)
        {
            if (answer != 0)
            {
                log.ElementAt(QuestionIndex).idAnswer = answer - 1;
            }
            if (QuestionIndex == log.Count - 1)
            {
                return null;
            }
            else
            {
                return GetNextQuestion();
            }
        }
        private RequestResult GetNextQuestion()
        {
            var rr = new RequestResult();
            QuestionIndex++;
            rr.Theme = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Name;
            rr.Question = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Questions.ElementAt(log.ElementAt(QuestionIndex).idQuestion).Name;
            rr.Answer1 = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Questions.ElementAt(log.ElementAt(QuestionIndex).idQuestion).Answers.ElementAt(0).Name;
            rr.Answer2 = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Questions.ElementAt(log.ElementAt(QuestionIndex).idQuestion).Answers.ElementAt(1).Name;
            rr.Answer3 = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Questions.ElementAt(log.ElementAt(QuestionIndex).idQuestion).Answers.ElementAt(2).Name;
            rr.Answer4 = data.testData.Subjects.ElementAt(log.ElementAt(QuestionIndex).IdTheme).Questions.ElementAt(log.ElementAt(QuestionIndex).idQuestion).Answers.ElementAt(3).Name;
            rr.IdTrueAnswer = log.ElementAt(QuestionIndex).idTrueAnswer;
            return rr;
        }

        private object View_CloseTest(Form logView)
        {
            constructResult();
            data.UploadXML(result);
            data.user.UpdateResult(result);
            Close(log, logView, result);
            return null;
        }

        private void constructResult()
        {
            int[] res = new int[4];

            foreach (var a in log)
            {
                if (a.idAnswer == a.idTrueAnswer)
                    res[a.IdTheme]++;
            }
            result.r1 = (Math.Round((double)res[0] / (double)data.testData.Subjects.ElementAt(0).QCount, 2)).ToString();
            result.r2 = (Math.Round((double)res[1] / (double)data.testData.Subjects.ElementAt(1).QCount, 2)).ToString();
            result.r3 = (Math.Round((double)res[2] / (double)data.testData.Subjects.ElementAt(2).QCount, 2)).ToString();
            result.r4 = (Math.Round((double)res[3] / (double)data.testData.Subjects.ElementAt(3).QCount, 2)).ToString();
        }
    }
}
