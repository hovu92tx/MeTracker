using SQLite;

namespace MeTracker.Repositories
{
    public class LocationRepository : ILocationRepository
    {
        private SQLiteAsyncConnection connection;
        public async Task SaveAsync(Models.Location location) 
        {
            await Connection();
            await connection.InsertAsync(location);
        }

        private async Task Connection()
        {
            if(Connection != null)
            {
                return;
            }
            else
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Location.db");
                connection = new SQLiteAsyncConnection(databasePath);
                await connection.CreateTableAsync<Models.Location>();
            }

        }

    }
}
