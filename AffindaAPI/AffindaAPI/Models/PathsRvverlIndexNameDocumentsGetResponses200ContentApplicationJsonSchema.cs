// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Affinda.API.Models
{
    /// <summary> The PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema. </summary>
    public partial class PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema
    {
        /// <summary> Initializes a new instance of PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema. </summary>
        internal PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema()
        {
            Results = new ChangeTrackingList<PathsHryo8IndexNameDocumentsGetResponses200ContentApplicationJsonSchemaPropertiesResultsItems>();
        }

        /// <summary> Initializes a new instance of PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema. </summary>
        /// <param name="count"> Number of indexed documents in result. </param>
        /// <param name="next"> URL to request next page of results. </param>
        /// <param name="previous"> URL to request previous page of results. </param>
        /// <param name="results"></param>
        internal PathsRvverlIndexNameDocumentsGetResponses200ContentApplicationJsonSchema(int? count, string next, string previous, IReadOnlyList<PathsHryo8IndexNameDocumentsGetResponses200ContentApplicationJsonSchemaPropertiesResultsItems> results)
        {
            Count = count;
            Next = next;
            Previous = previous;
            Results = results;
        }

        /// <summary> Number of indexed documents in result. </summary>
        public int? Count { get; }
        /// <summary> URL to request next page of results. </summary>
        public string Next { get; }
        /// <summary> URL to request previous page of results. </summary>
        public string Previous { get; }
        /// <summary> Gets the results. </summary>
        public IReadOnlyList<PathsHryo8IndexNameDocumentsGetResponses200ContentApplicationJsonSchemaPropertiesResultsItems> Results { get; }
    }
}
