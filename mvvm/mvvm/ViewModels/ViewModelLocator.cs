using GalaSoft.MvvmLight.Ioc;

namespace mvvm.ViewModels
{
    public class ViewModelLocator
    {
        public MainPageViewModel MainPageViewModel => SimpleIoc.Default.GetInstance<MainPageViewModel>();
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
        }
    }
}

