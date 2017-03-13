using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using DPXamarin.Model;

namespace DPXamarin.Services
{
    public class AzureService<T>
    {
        private IMobileServiceClient Client;
        private IMobileServiceTable<T> Table;

        const string dbPath = "comicDB";

        public AzureService()
        {
            string MyAppServiceURL = "http://dpxamarin.azurewebsites.net";
            Client = new MobileServiceClient(MyAppServiceURL);
            //falta adicionar a referencia Sqlite.storeDB
            var store = new MobileServiceSQLiteStore(dbPath);
            store.DefineTable<Comic>();
            Client.SyncContext.IsInitialized();
            Table = Client.GetTable<T>();
        }

        public async Task<IEnumerable<Comic>> GetComics()
        {
            var empty = new Comic[0];

            try
            {
                if (Plugin.Connectivity.CrossConnectivity.Current.IsConnected)
                    await SyncAsync();

                return await _table.ToEnumerableAsync();
            }
            catch (Exception ex)
            {
                return empty;
            }
        }

        public async void AddContact(Comic comic)
        {
            await _table.InsertAsync(comic);

        }

        public async Task SyncAsync()
        {
            ReadOnlyCollection<MobileServiceTableOperationError> syncErrors = null;
            try
            {
                await _client.SyncContext.PushAsync();

                await _table.PullAsync("comic", _table.CreateQuery());
            }
            catch (MobileServicePushFailedException pushEx)
            {
                if (pushEx.PushResult != null)
                    syncErrors = pushEx.PushResult.Errors;
            }
        }


        public async Task CleanData()
        {
            await _table.PurgeAsync("comic", _table.CreateQuery(), new System.Threading.CancellationToken());
        }
    }
}
