using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presenter.Common
{
     public class TestLog
    {
        public int IdTheme { get; }
        public int idQuestion { get; }
        public int idTrueAnswer { get; }
        public int idAnswer { get; set; }
        public TestLog(int idT, int idQ, int idTA, int idA)
        {
            IdTheme = idT;
            idQuestion = idQ;
            idTrueAnswer = idTA;
            idAnswer = idA;
        }
    }
}
