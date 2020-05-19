﻿// <copyright file="Constants.cs" company="James Jackson-South, Jeavon Leopold, and contributors">
// Copyright (c) James Jackson-South, Jeavon Leopold, and contributors. All rights reserved.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace Our.Umbraco.FileSystemProviders.Azure
{
    /// <summary>
    /// Constant strings for use within the application.
    /// </summary>
    public static class Constants
    {
        /// <summary>
        /// The default route path for media objects.
        /// </summary>
        public const string DefaultMediaRoute = "media";

        /// <summary>
        /// The configuration setting constants.
        /// </summary>
        public static class Configuration
        {
            /// <summary>
            /// The prefix for all appSettings
            /// </summary>
            public const string ConfigrationSettingPrefix = "AzureBlobFileSystem";
            
            /// <summary>
            /// The configuration key for disabling the virtual path provider.
            /// </summary>
            public const string DisableVirtualPathProviderKey = "AzureBlobFileSystem.DisableVirtualPathProvider";

            /// <summary>
            /// The configuration key for enabling the storage emulator.
            /// </summary>
            public const string UseStorageEmulatorKey = "AzureBlobFileSystem.UseStorageEmulator";

            /// <summary>
            /// The configuration key for providing the connection string via the web.config
            /// </summary>
            public const string ConnectionStringKey = "AzureBlobFileSystem.ConnectionString";

            /// <summary>
            /// The configuration key for providing the connection string via keyVault, ConnectionString can be left empty.
            /// </summary>
            public const string ConnectionStringKeyVaultKey = "AzureBlobFileSystem.ConnectionStringKeyVault";

            /// <summary>
            /// The configuration key for providing the Azure Blob Container Name via the web.config
            /// </summary>
            public const string ContainerNameKey = "AzureBlobFileSystem.ContainerName";

            /// <summary>
            /// The configuration key for providing the Storage Root URL via the web.config
            /// </summary>
            public const string RootUrlKey = "AzureBlobFileSystem.RootUrl";

            /// <summary>
            /// The configuration key for providing the Maximum Days Cache value via the web.config
            /// </summary>
            public const string MaxDaysKey = "AzureBlobFileSystem.MaxDays";

            /// <summary>
            /// The configuration key for providing the Use Default Root value via the web.config
            /// </summary>
            public const string UseDefaultRouteKey = "AzureBlobFileSystem.UseDefaultRoute";

            /// <summary>
            /// The configuration key for providing the Use Private Container value via the web.config
            /// </summary>
            public const string UsePrivateContainer = "AzureBlobFileSystem.UsePrivateContainer";
        }
    }
}
