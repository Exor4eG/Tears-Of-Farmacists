﻿using Model;
using Presenter.Common;
using Presenter.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Presenters
{
    class LoginPresenter: BasePresenter<ILoginForm>
    {
        private Data data;
        public LoginPresenter(ILoginForm view, Data d) : base(view)
        {
            data = d;
            View.Login += View_Login;
        }

        private bool View_Login(string arg1, string arg2)
        {
            return data.Login(arg1, arg2);
        }
    }
    
}
