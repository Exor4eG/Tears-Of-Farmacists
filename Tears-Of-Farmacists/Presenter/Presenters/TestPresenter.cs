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
    class TestPresenter : BasePresenter<ITestForm>
    {
        private Data data;
        public TestPresenter(ITestForm view, Data d) : base(view)
        {
            data = d;
        }
    }
}
