using SQLite;

namespace mvvm.Models
{
    public class Favorite
    {
        [PrimaryKey,AutoIncrement]
        public int Id { get; set; }
        public bool IsFavorite { get; set; }
    }
}
