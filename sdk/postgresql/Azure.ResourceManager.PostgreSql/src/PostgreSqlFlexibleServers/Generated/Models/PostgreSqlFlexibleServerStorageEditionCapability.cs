// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.PostgreSql.FlexibleServers.Models
{
    /// <summary> Storage edition capability. </summary>
    public partial class PostgreSqlFlexibleServerStorageEditionCapability : PostgreSqlBaseCapability
    {
        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageEditionCapability. </summary>
        internal PostgreSqlFlexibleServerStorageEditionCapability()
        {
            SupportedStorageCapabilities = new ChangeTrackingList<PostgreSqlFlexibleServerStorageCapability>();
        }

        /// <summary> Initializes a new instance of PostgreSqlFlexibleServerStorageEditionCapability. </summary>
        /// <param name="capabilityStatus"> The status of the capability. </param>
        /// <param name="reason"> The reason for the capability not being available. </param>
        /// <param name="name"> Storage edition name. </param>
        /// <param name="defaultStorageSizeMb"> Default storage size in MB for storage edition. </param>
        /// <param name="supportedStorageCapabilities"> Flexible server supported storage range in MB. </param>
        internal PostgreSqlFlexibleServerStorageEditionCapability(PostgreSqlFlexbileServerCapabilityStatus? capabilityStatus, string reason, string name, long? defaultStorageSizeMb, IReadOnlyList<PostgreSqlFlexibleServerStorageCapability> supportedStorageCapabilities) : base(capabilityStatus, reason)
        {
            Name = name;
            DefaultStorageSizeMb = defaultStorageSizeMb;
            SupportedStorageCapabilities = supportedStorageCapabilities;
        }

        /// <summary> Storage edition name. </summary>
        public string Name { get; }
        /// <summary> Default storage size in MB for storage edition. </summary>
        public long? DefaultStorageSizeMb { get; }
        /// <summary> Flexible server supported storage range in MB. </summary>
        public IReadOnlyList<PostgreSqlFlexibleServerStorageCapability> SupportedStorageCapabilities { get; }
    }
}
