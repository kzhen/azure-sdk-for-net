// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace Azure.ResourceManager.IotFirmwareDefense.Models
{
    /// <summary> Properties of the SBOM component for a CVE. </summary>
    public partial class CveComponent
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

        /// <summary> Initializes a new instance of <see cref="CveComponent"/>. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public CveComponent()
        {
        }

        /// <summary> Initializes a new instance of <see cref="CveComponent"/>. </summary>
        /// <param name="componentId"> ID of the SBOM component. </param>
        /// <param name="name"> Name of the SBOM component. </param>
        /// <param name="version"> Version of the SBOM component. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        [EditorBrowsable(EditorBrowsableState.Never)]
        internal CveComponent(string componentId, string name, string version, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ComponentId = componentId;
            Name = name;
            Version = version;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> ID of the SBOM component. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string ComponentId { get; set; }
        /// <summary> Name of the SBOM component. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Name { get; set; }
        /// <summary> Version of the SBOM component. </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public string Version { get; set; }
    }
}
