// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ExpectedRemunerationAnnotationV2Parsed. </summary>
    public partial class ExpectedRemunerationAnnotationV2Parsed
    {
        /// <summary> Initializes a new instance of ExpectedRemunerationAnnotationV2Parsed. </summary>
        internal ExpectedRemunerationAnnotationV2Parsed()
        {
        }

        /// <summary> Initializes a new instance of ExpectedRemunerationAnnotationV2Parsed. </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        /// <param name="currency"></param>
        /// <param name="unit"></param>
        internal ExpectedRemunerationAnnotationV2Parsed(float? minimum, float? maximum, string currency, string unit)
        {
            Minimum = minimum;
            Maximum = maximum;
            Currency = currency;
            Unit = unit;
        }

        /// <summary> Gets the minimum. </summary>
        public float? Minimum { get; }
        /// <summary> Gets the maximum. </summary>
        public float? Maximum { get; }
        /// <summary> Gets the currency. </summary>
        public string Currency { get; }
        /// <summary> Gets the unit. </summary>
        public string Unit { get; }
    }
}
