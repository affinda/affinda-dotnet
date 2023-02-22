// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Affinda.API.Models
{
    /// <summary> Years of experience range. </summary>
    public partial class YearsExperienceAnnotationV2UpdateParsed
    {
        /// <summary> Initializes a new instance of YearsExperienceAnnotationV2UpdateParsed. </summary>
        public YearsExperienceAnnotationV2UpdateParsed()
        {
        }

        /// <summary> Initializes a new instance of YearsExperienceAnnotationV2UpdateParsed. </summary>
        /// <param name="minimum"> Minimum years of experience. </param>
        /// <param name="maximum"> Maximum years of experience. </param>
        internal YearsExperienceAnnotationV2UpdateParsed(float? minimum, float? maximum)
        {
            Minimum = minimum;
            Maximum = maximum;
        }

        /// <summary> Minimum years of experience. </summary>
        public float? Minimum { get; set; }
        /// <summary> Maximum years of experience. </summary>
        public float? Maximum { get; set; }
    }
}
