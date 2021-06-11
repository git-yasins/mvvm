using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvm.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        private string _result;
        public string Result {
            get => _result;
            set => Set(nameof(Result), ref _result, value);
        }

        private RelayCommand _command;
        public RelayCommand Command => _command ?? new RelayCommand(() => Result = "test");
    }
}
