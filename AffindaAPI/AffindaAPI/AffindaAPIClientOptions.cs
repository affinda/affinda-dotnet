// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using Azure.Core;

namespace Affinda.API
{
    /// <summary> Client options for AffindaAPIClient. </summary>
    public partial class AffindaAPIClientOptions : ClientOptions
    {
        private const ServiceVersion LatestVersion = ServiceVersion.Vv2;

        /// <summary> The version of the service to use. </summary>
        public enum ServiceVersion
        {
            /// <summary> Service version "v2". </summary>
            Vv2 = 1,
        }

        internal string Version { get; }

        /// <summary> Initializes new instance of AffindaAPIClientOptions. </summary>
        public AffindaAPIClientOptions(ServiceVersion version = LatestVersion)
        {
            Version = version switch
            {
                ServiceVersion.Vv2 => "v2",
                _ => throw new NotSupportedException()
            };
        }
    }
}
