using SwanSong.Helper;
using System;

namespace SwanSong.Azure.Storage
{
    public class Base
    {
        public Base(){
        }

        public string GetStorageConnection()
        {
            return Environment.GetEnvironmentVariable(Constants.AzureStorageConnectionStringUat);
        }
    }
}
