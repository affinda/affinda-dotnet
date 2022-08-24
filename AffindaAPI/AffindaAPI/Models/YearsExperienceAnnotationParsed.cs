// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> Years of experience range. </summary>
    public partial class YearsExperienceAnnotationParsed
    {
        /// <summary> Initializes a new instance of YearsExperienceAnnotationParsed. </summary>
        internal YearsExperienceAnnotationParsed()
        {
        }

        /// <summary> Initializes a new instance of YearsExperienceAnnotationParsed. </summary>
        /// <param name="minimum"> Minimum years of experience. </param>
        /// <param name="maximum"> Maximum years of experience. </param>
        internal YearsExperienceAnnotationParsed(float? minimum, float? maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary> Minimum years of experience. </summary>
        public float? Minimum { get; }
        /// <summary> Maximum years of experience. </summary>
        public float? Maximum { get; }
    }
}