using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using mvvm.Services;
using MvvmHelpers;

namespace mvvm.Models
{
    public class DatabasePageViewModel : ViewModelBase
    {
        private IFavoriteStorage _favoriteStorage;
        private RelayCommand _createDatabaseCommand;
        public DatabasePageViewModel(IFavoriteStorage favoriteStorage)
        {
            _favoriteStorage = favoriteStorage;
        }
        public RelayCommand CreateDatabaseCommand => _createDatabaseCommand
            ?? new RelayCommand(async () => await _favoriteStorage.CreateDatabaseAsync());

        private RelayCommand _insertDatabaseCommand;
        public RelayCommand InsertDatabaseCommand => _insertDatabaseCommand
            ?? new RelayCommand(async () => await _favoriteStorage.InsertDataAsync(new Favorite { IsFavorite = true }));

        private RelayCommand _ReadDatabaseCommand;
        public RelayCommand ReadDatabaseCommand => _ReadDatabaseCommand
            ?? new RelayCommand(async () => Favorites.AddRange(await _favoriteStorage.ReadDataAsync()));

        public ObservableRangeCollection<Favorite> Favorites { get; } = new ObservableRangeCollection<Favorite>();
    }
}
 