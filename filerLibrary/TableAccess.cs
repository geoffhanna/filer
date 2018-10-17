using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Table;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

[assembly: InternalsVisibleTo("filer.Test")]

namespace filerLibrary
{

    internal static class TableAccess
    {

        private static CloudStorageAccount _acct = null;

        static TableAccess()
        {
            if (_acct == null)
            {
                //  TODO: shame on you for hard-coding this
                _acct = new CloudStorageAccount(new Microsoft.WindowsAzure.Storage.Auth.StorageCredentials("geoffhanna", "QqDardFEdtfBKN2qnsuCfcL4EeF7iW/3G3n/izEvSmyZ9fUa9Px+albZ47LIy9kDzfRuoOmoj/3U2VB5I1+Y5w=="), true);
            }
        }

        internal static CloudTable GetTable(string tableName)
        {
            return _acct.CreateCloudTableClient().GetTableReference(tableName);
        }
    }
}
