using MassTransit.Futures.Contracts;

namespace Mira_Common.Settings
{
    public class MongoDbSettings
    {
        public MongoDbSettings(string? username, string? password, string? host)
        {
            Username = username;
            Password = password;
            Host = host;
        }

        private string? Username { get; }
        private string? Password { get; }
        private string? Host { get; }
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