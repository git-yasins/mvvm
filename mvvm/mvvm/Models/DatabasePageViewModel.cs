using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace mvvm.Models
{
    public class DatabasePageViewModel : ViewModelBase
    {
        private RelayCommand _createDatabaseCommand;
        public RelayCommand CreateDatabaseCommand => _createDatabaseCommand ?? new RelayCommand(() => { });
    }
}
