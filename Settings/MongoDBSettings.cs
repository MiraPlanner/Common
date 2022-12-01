namespace Mira_Common.Settings
{
    public class MongoDbSettings
    {
        private string? Username { get; init; }
        private string? Password { get; init; }
        private string Host { get; init; }
        public int Port { get; init; }
        
        public string ConnectionString => GetConnectionString();
        
        public string GetConnectionString()
        {
            if (Username == null || Password == null)
                return $"mongodb://{Host}:{Port}";
            return $"{Username}:{Password}@mongodb://{Host}:{Port}";
        }
    }
}