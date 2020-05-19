namespace Our.Umbraco.FileSystemProviders.Azure
{
    using System.Configuration;
    using Microsoft.Azure.KeyVault;
    using Microsoft.Azure.Services.AppAuthentication;

    public class ConfigurationHelper
    {
        public static string GetAppSetting(string key)
        {
            // try getting connection string with keyVault instead of direct connectionString input
            if (key == Constants.Configuration.ConnectionStringKey && !string.IsNullOrEmpty(ConfigurationManager.AppSettings[Constants.Configuration.ConnectionStringKeyVaultKey]))
            {
                return GetConnectionStringByKeyVaultKey(ConfigurationManager.AppSettings[Constants.Configuration.ConnectionStringKeyVaultKey]);
            }

            return ConfigurationManager.AppSettings[key];
        }

        public static string GetAppSetting(string key, string providerAlias)
        {
            // try getting connection string with keyVault instead of direct connectionString input
            if (key == Constants.Configuration.ConnectionStringKey && !string.IsNullOrEmpty(ConfigurationManager.AppSettings[$"{Constants.Configuration.ConnectionStringKeyVaultKey}:{providerAlias}"]))
            {
                return GetConnectionStringByKeyVaultKey(ConfigurationManager.AppSettings[$"{Constants.Configuration.ConnectionStringKeyVaultKey}:{providerAlias}"]);
            }

            return ConfigurationManager.AppSettings[$"{key}:{providerAlias}"];
        }

        private static string GetConnectionStringByKeyVaultKey(string vaultUrl)
        {
            if (string.IsNullOrEmpty(vaultUrl))
            {
                return "";
            }

            var azureServiceTokenProvider = new AzureServiceTokenProvider();
            var authenticationCallback = new KeyVaultClient.AuthenticationCallback(azureServiceTokenProvider.KeyVaultTokenCallback);
            var keyVaultClient = new KeyVaultClient(authenticationCallback);
            var secret = keyVaultClient.GetSecretAsync(vaultUrl).Result;
            return secret.Value;
        }
    }
}