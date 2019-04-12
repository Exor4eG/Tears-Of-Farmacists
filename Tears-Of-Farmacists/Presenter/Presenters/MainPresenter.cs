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
            View.SetChooseOne += View_SetChooseOne;
            View.SetChooseTwo += View_SetChooseTwo;
        }

        private void View_SetChooseTwo()
        {
            data.choose = 2;
        }

        private void View_SetChooseOne()
        {
            data.choose = 1;
        }

        private string View_GetTestTime()
        {
            double time = (double)data.testData.Setting.Time / (double)60;
            return time.ToString();
        }

        private string View_GetQCount()
        {
            int count = 0;
            foreach(var i in data.testData.Subjects)
            {
                count += i.QCount;
            }
            return count.ToString();
        }

        private List<string[]> View_GetResults()
        {
            List<string[]> res = new List<string[]>();
            foreach(var result in data.user.results)
            {
                res.Add(new string[] { result.r1, result.r2, result.r3, result.r4, result.date});
            }
            return res;
        }

        private string View_GetInfo()
        {
            return data.testData.Info;
        }
    }
}
