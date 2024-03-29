// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
    public partial class PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1
    {
        /// <summary> Initializes a new instance of PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        internal PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1()
        {
            Results = new ChangeTrackingList<Mapping>();
        }

        /// <summary> Initializes a new instance of PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1. </summary>
        /// <param name="results"></param>
        internal PathsWvcyp9V3MappingsGetResponses200ContentApplicationJsonSchemaAllof1(IReadOnlyList<Mapping> results)
        {
            Results = results;
        }

        /// <summary> Gets the results. </summary>
        public IReadOnlyList<Mapping> Results { get; }
    }
}
