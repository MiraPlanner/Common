namespace Mira_Common.Settings
{
    public class MongoDbSettings
    {
        public string? Username { get; init; }
        public string? Password { get; init; }
        public string Host { get; init; }
        public int Port { get; init; }
        
        public string ConnectionString => GetConnectionString();
        
        public string GetConnectionString()
        {
            if (Username == null || Password == null)
                return $"mongodb://{Host}:{Port}";
            return $"mongodb://{Username}:{Password}@{Host}:{Port}";
        }
    }
}