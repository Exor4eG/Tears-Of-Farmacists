using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Views
{
    public interface ILogViewForm : IView
    {
        event Action CloseLog;
        event Func<List<string[]>> GetData;
        event Func<Result> GetResult;
    }
}
