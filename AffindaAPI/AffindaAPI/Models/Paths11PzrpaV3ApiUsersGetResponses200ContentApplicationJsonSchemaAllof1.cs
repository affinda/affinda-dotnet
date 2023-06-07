// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
    public partial class Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1
    {
        /// <summary> Initializes a new instance of Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        internal Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1()
        {
            Results = new ChangeTrackingList<ApiUserWithoutKey>();
        }

        /// <summary> Initializes a new instance of Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        /// <param name="results"></param>
        internal Paths11PzrpaV3ApiUsersGetResponses200ContentApplicationJsonSchemaAllof1(IReadOnlyList<ApiUserWithoutKey> results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<ApiUserWithoutKey> Results { get; }
    }
}
