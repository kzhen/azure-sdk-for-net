// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.RedisEnterprise.Models;

namespace Azure.ResourceManager.RedisEnterprise
{
    /// <summary>
    /// A class representing the RedisEnterpriseDatabase data model.
    /// Describes a database on the Redis Enterprise cluster
    /// </summary>
    public partial class RedisEnterpriseDatabaseData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseData"/>. </summary>
        public RedisEnterpriseDatabaseData()
        {
            Modules = new ChangeTrackingList<RedisEnterpriseModule>();
        }

        /// <summary> Initializes a new instance of <see cref="RedisEnterpriseDatabaseData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="clientProtocol"> Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted. </param>
        /// <param name="port"> TCP port of the database endpoint. Specified at create time. Defaults to an available port. </param>
        /// <param name="provisioningState"> Current provisioning status of the database. </param>
        /// <param name="resourceState"> Current resource status of the database. </param>
        /// <param name="clusteringPolicy"> Clustering policy - default is OSSCluster. This property can be updated only if the current value is NoCluster. If the value is OSSCluster or EnterpriseCluster, it cannot be updated without deleting the database. </param>
        /// <param name="evictionPolicy"> Redis eviction policy - default is VolatileLRU. </param>
        /// <param name="persistence"> Persistence settings. </param>
        /// <param name="modules"> Optional set of redis modules to enable in this database - modules can only be added at creation time. </param>
        /// <param name="geoReplication"> Optional set of properties to configure geo replication for this database. </param>
        /// <param name="redisVersion"> Version of Redis the database is running on, e.g. '6.0'. </param>
        /// <param name="deferUpgrade"> Option to defer upgrade when newest version is released - default is NotDeferred. Learn more: https://aka.ms/redisversionupgrade. </param>
        /// <param name="accessKeysAuthentication"> This property can be Enabled/Disabled to allow or deny access with the current access keys. Can be updated even after database is created. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RedisEnterpriseDatabaseData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, RedisEnterpriseClientProtocol? clientProtocol, int? port, RedisEnterpriseProvisioningStatus? provisioningState, RedisEnterpriseClusterResourceState? resourceState, RedisEnterpriseClusteringPolicy? clusteringPolicy, RedisEnterpriseEvictionPolicy? evictionPolicy, RedisPersistenceSettings persistence, IList<RedisEnterpriseModule> modules, RedisEnterpriseDatabaseGeoReplication geoReplication, string redisVersion, DeferUpgradeSetting? deferUpgrade, AccessKeysAuthentication? accessKeysAuthentication, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ClientProtocol = clientProtocol;
            Port = port;
            ProvisioningState = provisioningState;
            ResourceState = resourceState;
            ClusteringPolicy = clusteringPolicy;
            EvictionPolicy = evictionPolicy;
            Persistence = persistence;
            Modules = modules;
            GeoReplication = geoReplication;
            RedisVersion = redisVersion;
            DeferUpgrade = deferUpgrade;
            AccessKeysAuthentication = accessKeysAuthentication;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Specifies whether redis clients can connect using TLS-encrypted or plaintext redis protocols. Default is TLS-encrypted. </summary>
        [WirePath("properties.clientProtocol")]
        public RedisEnterpriseClientProtocol? ClientProtocol { get; set; }
        /// <summary> TCP port of the database endpoint. Specified at create time. Defaults to an available port. </summary>
        [WirePath("properties.port")]
        public int? Port { get; set; }
        /// <summary> Current provisioning status of the database. </summary>
        [WirePath("properties.provisioningState")]
        public RedisEnterpriseProvisioningStatus? ProvisioningState { get; }
        /// <summary> Current resource status of the database. </summary>
        [WirePath("properties.resourceState")]
        public RedisEnterpriseClusterResourceState? ResourceState { get; }
        /// <summary> Clustering policy - default is OSSCluster. This property can be updated only if the current value is NoCluster. If the value is OSSCluster or EnterpriseCluster, it cannot be updated without deleting the database. </summary>
        [WirePath("properties.clusteringPolicy")]
        public RedisEnterpriseClusteringPolicy? ClusteringPolicy { get; set; }
        /// <summary> Redis eviction policy - default is VolatileLRU. </summary>
        [WirePath("properties.evictionPolicy")]
        public RedisEnterpriseEvictionPolicy? EvictionPolicy { get; set; }
        /// <summary> Persistence settings. </summary>
        [WirePath("properties.persistence")]
        public RedisPersistenceSettings Persistence { get; set; }
        /// <summary> Optional set of redis modules to enable in this database - modules can only be added at creation time. </summary>
        [WirePath("properties.modules")]
        public IList<RedisEnterpriseModule> Modules { get; }
        /// <summary> Optional set of properties to configure geo replication for this database. </summary>
        [WirePath("properties.geoReplication")]
        public RedisEnterpriseDatabaseGeoReplication GeoReplication { get; set; }
        /// <summary> Version of Redis the database is running on, e.g. '6.0'. </summary>
        [WirePath("properties.redisVersion")]
        public string RedisVersion { get; }
        /// <summary> Option to defer upgrade when newest version is released - default is NotDeferred. Learn more: https://aka.ms/redisversionupgrade. </summary>
        [WirePath("properties.deferUpgrade")]
        public DeferUpgradeSetting? DeferUpgrade { get; set; }
        /// <summary> This property can be Enabled/Disabled to allow or deny access with the current access keys. Can be updated even after database is created. </summary>
        [WirePath("properties.accessKeysAuthentication")]
        public AccessKeysAuthentication? AccessKeysAuthentication { get; set; }
    }
}
