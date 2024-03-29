// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace Affinda.API.Models
{
    /// <summary> The DataPointChoiceReplaceResponse. </summary>
    public partial class DataPointChoiceReplaceResponse
    {
        /// <summary> Initializes a new instance of DataPointChoiceReplaceResponse. </summary>
        /// <param name="dataPoint"> Uniquely identify a data point. </param>
        /// <param name="collection"> Uniquely identify a collection. </param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="choices"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataPoint"/> or <paramref name="choices"/> is null. </exception>
        internal DataPointChoiceReplaceResponse(string dataPoint, string collection, string organization, IEnumerable<DataPointChoiceReplaceResponseChoicesItem> choices)
        {
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }
            if (choices == null)
            {
                throw new ArgumentNullException(nameof(choices));
            }

            DataPoint = dataPoint;
            Collection = collection;
            Organization = organization;
            Choices = choices.ToList();
        }

        /// <summary> Initializes a new instance of DataPointChoiceReplaceResponse. </summary>
        /// <param name="dataPoint"> Uniquely identify a data point. </param>
        /// <param name="collection"> Uniquely identify a collection. </param>
        /// <param name="organization"> Uniquely identify an organization. </param>
        /// <param name="choices"></param>
        internal DataPointChoiceReplaceResponse(string dataPoint, string collection, string organization, IReadOnlyList<DataPointChoiceReplaceResponseChoicesItem> choices)
        {
            DataPoint = dataPoint;
            Collection = collection;
            Organization = organization;
            Choices = choices;
        }

        /// <summary> Uniquely identify a data point. </summary>
        public string DataPoint { get; }
        /// <summary> Uniquely identify a collection. </summary>
        public string Collection { get; }
        /// <summary> Uniquely identify an organization. </summary>
        public string Organization { get; }
        /// <summary> Gets the choices. </summary>
        public IReadOnlyList<DataPointChoiceReplaceResponseChoicesItem> Choices { get; }
    }
}
