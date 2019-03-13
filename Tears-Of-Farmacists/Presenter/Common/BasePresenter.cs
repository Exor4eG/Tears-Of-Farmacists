namespace Presenter.Common
{
    class BasePresenter<TView>
    {
        protected TView View { get; private set; }

        protected BasePresenter(TView view)
        {
            View = view;
        }
    }
}
