using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Views
{
    public interface ILoginForm : IView
    {
        event Func<string, string, bool> Login;
    }
}
