﻿using Model;
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
    class MainPresenter : BasePresenter<IMainForm>
    {
        private Data data;

        public MainPresenter(IMainForm view, Data d) : base(view)
        {
            data = d;
            View.GetInfo += View_GetInfo;
            View.GetResults += View_GetResults;
            View.GetQCount += View_GetQCount;
            View.GetTestTime += View_GetTestTime;
            View.StartTest += View_StartTest;
            View.GetFontSize += View_GetFontSize;
            View.SetFontSize += View_SetFontSize;
            View.OpenTraining += View_OpenTraining;
        }

        private void View_OpenTraining(Form trainingForm)
        {
            TrainingPresenter tp = new TrainingPresenter((ITrainingForm)trainingForm, data);
            trainingForm.Show();
            tp.Close += Lvp_Close;
        }

        private void View_SetFontSize(int fontSize)
        {
            data.SaveFontSize(fontSize);
        }

        private int View_GetFontSize()
        {
            return data.FontSize;
        }

        private object View_StartTest(Form test)
        {
            TestPresenter tp = new TestPresenter((ITestForm)test, data);
            test.Show();
            tp.Close += Tp_Close;
            return null;
        }


        private object Tp_Close(List<TestLog> log, Form logView, Result res)
        {
            LogViewPresenter lvp = new LogViewPresenter((ILogViewForm)logView, data, log, res);
            logView.Show();
            lvp.Close += Lvp_Close;
            return null;
        }

        private void Lvp_Close()
        {
            View.Show();
        }

        private string View_GetTestTime()
        {
            return data.testData.Setting.Time.ToString();
        }

        private string View_GetQCount()
        {
            int count = 0;
            foreach (var i in data.testData.Subjects)
            {
                count += i.QCount;
            }
            return count.ToString();
        }

        private List<string[]> View_GetResults()
        {
            List<string[]> res = new List<string[]>();
            foreach (var result in data.user.results)
            {
                res.Add(new string[]
                {
                    string.Format("{0}%", Convert.ToDouble(result.r1) * 100),
                    string.Format("{0}%", Convert.ToDouble(result.r2) * 100),
                    string.Format("{0}%", Convert.ToDouble(result.r3) * 100),
                    string.Format("{0}%", Convert.ToDouble(result.r4) * 100),
                    result.date
                });
            }
            return res;
        }

        private string View_GetInfo()
        {
            return data.testData.Info;
        }
    }
}
