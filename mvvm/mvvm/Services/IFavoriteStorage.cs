using mvvm.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace mvvm.Services
{
    public interface IFavoriteStorage
    {
        Task CreateDatabaseAsync();
        Task InsertDataAsync(Favorite favorite);
        Task<IList<Favorite>> ReadDataAsync();
    }
}
