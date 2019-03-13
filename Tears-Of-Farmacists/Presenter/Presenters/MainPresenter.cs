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
        }
    }
}
