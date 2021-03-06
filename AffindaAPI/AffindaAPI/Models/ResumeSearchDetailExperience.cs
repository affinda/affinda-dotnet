// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> The ResumeSearchDetailExperience. </summary>
    public partial class ResumeSearchDetailExperience
    {
        /// <summary> Initializes a new instance of ResumeSearchDetailExperience. </summary>
        internal ResumeSearchDetailExperience()
        {
        }

        /// <summary> Initializes a new instance of ResumeSearchDetailExperience. </summary>
        /// <param name="years"></param>
        /// <param name="match"></param>
        internal ResumeSearchDetailExperience(int? years, bool? match)
        {
            Years = years;
            Match = match;
        }

        /// <summary> Gets the years. </summary>
        public int? Years { get; }
        /// <summary> Gets the match. </summary>
        public bool? Match { get; }
    }
}
