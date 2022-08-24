// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The OccupationGroupSearchScoreComponent. </summary>
    public partial class OccupationGroupSearchScoreComponent
    {
        /// <summary> Initializes a new instance of OccupationGroupSearchScoreComponent. </summary>
        /// <param name="label"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> is null. </exception>
        internal OccupationGroupSearchScoreComponent(string label)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            Label = label;
        }

        /// <summary> Initializes a new instance of OccupationGroupSearchScoreComponent. </summary>
        /// <param name="value"></param>
        /// <param name="label"></param>
        /// <param name="score"></param>
        internal OccupationGroupSearchScoreComponent(string value, string label, float? score)
        {
            Value = value;
            Label = label;
            Score = score;
        }

        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets the label. </summary>
        public string Label { get; }
        /// <summary> Gets the score. </summary>
        public float? Score { get; }
    }
}