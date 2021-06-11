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

        private RelayCommand _insertDatabaseCommand;
        public RelayCommand InsertDatabaseCommand => _insertDatabaseCommand ?? new RelayCommand(() => { });

        private RelayCommand _getDatabaseCommand;
        public RelayCommand GetDatabaseCommand => _getDatabaseCommand ?? new RelayCommand(() => { });
    }
}
