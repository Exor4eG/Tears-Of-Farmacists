using Model;
using Presenter.Presenters;
using Presenter.Views;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presenter.Common
{
    public class Context : ApplicationContext
    {
        Data data = null;
        private Form preview = null;
        private Form main = null;
        private Form test = null;
        private Form login = null;
        Timer timer = new Timer();

        public Context(Form preview, Form main, Form test, Form login)
        {
            data = new Data();
            base.MainForm = preview;
            this.test = test;
            this.login = login;
            this.preview = preview;
            this.main = main;
            timer.Tick += new EventHandler(SplashTimeUp);
            data.DownloadAll();
            //Task task = new Task(() =>data.DownloadAll());
            timer.Interval = 6000;
            timer.Enabled = true;
        }

        private void SplashTimeUp(object sender, EventArgs e)
        {
            timer.Enabled = false;
            timer.Dispose();
            base.MainForm.Close();
        }
        protected override void OnMainFormClosed(object sender, EventArgs e)
        {
            if (sender is IPreviewForm)
            {
                if (data.downloadedFiles == true)
                {
                    data.Deserialize();
                    data.ReadXml();
                    new LoginPresenter((ILoginForm)login, data);
                    base.MainForm = login;
                    base.MainForm.Show();
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить файлы. Попробуйте зайти позже, либо обратитесь в IT-отдел", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    base.OnMainFormClosed(sender, e);
                }
            }
            else if (sender is ILoginForm)
            {
                if (data.user != null)
                {
                    data.ReadResults();
                    new MainPresenter((IMainForm)main, data);
                    base.MainForm = main;
                    base.MainForm.Show();
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else if (sender is IMainForm)
            {
                if (data.choose == 1)
                {
                    data.choose = 0;
                    //старт теста
                }
                else if (data.choose == 2)
                {
                    data.choose = 0;
                    //старт ознакомления
                }
                else
                {
                    base.OnMainFormClosed(sender, e);
                }
            }
            else if (sender is ITestForm)
            {
                //дописать
            }
        }
    }
}
