// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The CustomFieldConfig. </summary>
    public partial class CustomFieldConfig
    {
        /// <summary> Initializes a new instance of CustomFieldConfig. </summary>
        /// <param name="dataPoint"> Data point identifier. </param>
        /// <param name="weight"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="dataPoint"/> is null. </exception>
        public CustomFieldConfig(string dataPoint, float weight)
        {
            if (dataPoint == null)
            {
                throw new ArgumentNullException(nameof(dataPoint));
            }

            DataPoint = dataPoint;
            Weight = weight;
        }

        /// <summary> Data point identifier. </summary>
        public string DataPoint { get; set; }
        /// <summary> Gets or sets the weight. </summary>
        public float Weight { get; set; }
    }
}