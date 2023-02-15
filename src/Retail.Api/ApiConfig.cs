namespace RentalApi
{
    public class ApiConfig : IApiConfig
    {

        //ApiConfig(string name, string connectionString)
        //{
        //    Name = !string.IsNullOrWhiteSpace(name) ? name : throw new ArgumentException($"'{nameof(name)}' cannot be null or empty.", nameof(name));
        //    ConnectionString = !string.IsNullOrWhiteSpace(connectionString) ? connectionString : throw new ArgumentException($"'{nameof(connectionString)}' cannot be null or whitespace.", nameof(connectionString));
        //}

        public string Name { get; set; }

        public string ConnectionString { get; set; }
    }
}
