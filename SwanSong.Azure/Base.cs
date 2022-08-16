using Microsoft.Extensions.Options;
using SwanSong.Domain.Model.Settings.Azure;

namespace SwanSong.Azure.Storage
{
    public class Base
    {
        public readonly IOptions<AzureSettings> _azureSettings;

        public Base(IOptions<AzureSettings> azureSettings)
        {
            _azureSettings = azureSettings;
        }

        public string GetStorageConnection()
        {
            return _azureSettings.Value.Storage.Connection;
        }

    }
}
