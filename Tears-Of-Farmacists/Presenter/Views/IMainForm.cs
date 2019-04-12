using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Views
{
    public interface IMainForm : IView
    {
        event Func<string> GetInfo;
        event Func<List<string[]>> GetResults;
        event Func<string> GetTestTime;
        event Func<string> GetQCount;
        event Action SetChooseOne;
        event Action SetChooseTwo;
    }
}
