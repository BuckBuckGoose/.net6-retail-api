using System.Text.Json.Serialization;

namespace RentalApi
{
    public interface IApiConfig
    {
        string Name { get; }
        string ConnectionString { get; }
    }
}
