// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
    public partial class Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1
    {
        /// <summary> Initializes a new instance of Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        internal Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1()
        {
            Results = new ChangeTrackingList<OrganizationMembership>();
        }

        /// <summary> Initializes a new instance of Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        /// <param name="results"></param>
        internal Paths93Fa0ZV3OrganizationMembershipsGetResponses200ContentApplicationJsonSchemaAllof1(IReadOnlyList<OrganizationMembership> results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<OrganizationMembership> Results { get; }
    }
}
