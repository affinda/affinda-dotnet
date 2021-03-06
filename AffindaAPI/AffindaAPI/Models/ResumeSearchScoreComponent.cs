// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchScoreComponent. </summary>
    public partial class ResumeSearchScoreComponent
    {
        /// <summary> Initializes a new instance of ResumeSearchScoreComponent. </summary>
        /// <param name="label"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="label"/> is null. </exception>
        internal ResumeSearchScoreComponent(string label)
        {
            if (label == null)
            {
                throw new ArgumentNullException(nameof(label));
            }

            Label = label;
        }

        /// <summary> Initializes a new instance of ResumeSearchScoreComponent. </summary>
        /// <param name="label"></param>
        /// <param name="value"></param>
        /// <param name="score"></param>
        internal ResumeSearchScoreComponent(string label, string value, float? score)
        {
            Label = label;
            Value = value;
            Score = score;
        }

        /// <summary> Gets the label. </summary>
        public string Label { get; }
        /// <summary> Gets the value. </summary>
        public string Value { get; }
        /// <summary> Gets the score. </summary>
        public float? Score { get; }
    }
}
