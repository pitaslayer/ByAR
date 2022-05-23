namespace ByAR.Views
{
    public interface IView 
    {
        void CloseView();
        void OpenView(AViewController viewController);
    }
}