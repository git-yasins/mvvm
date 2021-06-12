using GalaSoft.MvvmLight.Ioc;
using mvvm.Models;
using mvvm.Services;

namespace mvvm.ViewModels
{
    public class ViewModelLocator
    {
        public MainPageViewModel MainPageViewModel => SimpleIoc.Default.GetInstance<MainPageViewModel>();
        public DatabasePageViewModel DatabasePageViewModel => SimpleIoc.Default.GetInstance<DatabasePageViewModel>();
        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainPageViewModel>();
            SimpleIoc.Default.Register<DatabasePageViewModel>();
            SimpleIoc.Default.Register<IFavoriteStorage, FavoriteStorage>();
        }
    }
}

