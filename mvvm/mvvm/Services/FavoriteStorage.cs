using mvvm.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Services
{
    public class FavoriteStorage : IFavoriteStorage
    {
        private SQLiteAsyncConnection connection = null;
        public async Task CreateDatabaseAsync()
        {
            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "mvvm.db3");
            connection = new SQLiteAsyncConnection(databasePath);
            await connection.CreateTableAsync<Favorite>();
        }
        public async Task InsertDataAsync(Favorite favorite) => await connection.InsertAsync(favorite);
        public async Task<IList<Favorite>> ReadDataAsync() => await connection.Table<Favorite>().ToListAsync();
    }
}
